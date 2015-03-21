<?php

	class ActivityController extends CController
	{
		public function actionWrite()
		{
			$type = Yii::app()->request->getPost('type');
			$subType = Yii::app()->request->getPost('subType');
			$data = Yii::app()->request->getPost('data');
			$recipients = Yii::app()->request->getPost('recipients');
			if (isset($data))
				$data = CJSON::decode($data);

			if (isset($recipients) && $recipients != '' && $subType == 'Open')
			{
				$ip = Yii::app()->request->getUserHostAddress();
				$message = Yii::app()->email;
				$message->to = explode(";", $recipients);
				$message->subject = 'Someone just viewed your presentation';
				$message->from = Yii::app()->params['email']['from'];
				$message->message = 'Someone just viewed a site: ' . $data['Name'] . '(' . $data['Site'] . ')' .
					'<br>IP Address: ' . $ip;
				$message->send();
			}

			if (isset($type) && isset($subType))
				ActivityRecord::WriteActivity($type, $subType, $data);
			Yii::app()->end();
		}
	}
