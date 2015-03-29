<?

	class ActivityController extends RestController
	{
		public function actionWrite()
		{
			$type = Yii::app()->request->getPut('type');
			$subType = Yii::app()->request->getPut('subType');
			$details = Yii::app()->request->getPut('details');
			$notificationRecipients = Yii::app()->request->getPut('notificationRecipients');
			if (!isset($details))
			{
				$this->renderJSON(ResponseCode::$BadRequest);
				return;
			}
			$details['Advertiser'] = str_replace("\'", "'", $details['Advertiser']);
			if (isset($notificationRecipients) && $notificationRecipients != '')
			{
				$userInfo = '';
				if (array_key_exists('User', $details) && $details['User'] != '')
					$userInfo = '<br>Logged in as: ' . $details['User'];

				$ip = Yii::app()->request->getUserHostAddress();
				$message = Yii::app()->email;
				$message->to = explode(";", $notificationRecipients);
				$message->subject = $details['Advertiser'];
				$message->from = Yii::app()->params['email']['from'];
				$message->message = 'Someone just viewed your client presentation for: ' . $details['Advertiser'] .
					$userInfo .
					'<br>IP Address: ' . $ip;
				$message->send();
			}

			if (isset($type) && isset($subType))
			{
				ActivityRecord::WriteActivity($type, $subType, $details);
				$this->renderJSON(ResponseCode::$OK);
			}
			else
				$this->renderJSON(ResponseCode::$BadRequest);
		}

		public function actionList()
		{
			$dateBegin = Yii::app()->request->getQuery('dateBegin');
			$dateEnd = Yii::app()->request->getQuery('dateEnd');
			$list = ActivityRecord::model()->findByDateRange($dateBegin, $dateEnd);
			$this->renderJSON(ResponseCode::$OK, $list);
		}
	}
