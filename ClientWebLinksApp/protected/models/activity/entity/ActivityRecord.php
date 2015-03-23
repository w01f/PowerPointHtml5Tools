<?php

	/**
	 * Class ActivityRecord
	 * @property string id
	 * @property mixed date_time
	 * @property string type
	 * @property string sub_type
	 */
	class ActivityRecord extends CActiveRecord
	{
		/**
		 * @param string $className
		 * @return ActivityRecord
		 */
		public static function model($className = __CLASS__)
		{
			return parent::model($className);
		}

		/**
		 * @return string
		 */
		public function tableName()
		{
			return '{{activity}}';
		}

		/**
		 * @return array
		 */
		public function relations()
		{
			return array(
				'userActivity' => array(self::HAS_ONE, 'ActivityUserRecord', 'id_activity'),
				'activityDetails' => array(self::HAS_MANY, 'ActivityDetailRecord', 'id_activity'),
			);
		}

		/**
		 * @param $dateBegin
		 * @param $dateEnd
		 * @return ActivityRawModel[]
		 */
		public function findByDateRange($dateBegin, $dateEnd)
		{
			$criteria = new CDbCriteria;
			$criteria->condition = 'date_time>=:start and date_time<=:end';
			$criteria->params = array(':start' => date(Yii::app()->params['mysqlDateFormat'], strtotime($dateBegin)), ':end' => date(Yii::app()->params['mysqlDateFormat'], strtotime($dateEnd)));
			$activityRecords = $this->with('userActivity', 'activityDetails')->findAll($criteria);

			$result = array();
			foreach ($activityRecords as $activityRecord)
			{
				$model = new ActivityRawModel();
				$model->id = $activityRecord->id;
				$model->date = $activityRecord->date_time;
				$model->type = $activityRecord->type;
				$model->subType = $activityRecord->sub_type;
				$model->ip = $activityRecord->userActivity->ip;
				$model->os = $activityRecord->userActivity->os;
				$model->device = $activityRecord->userActivity->device;
				$model->browser = $activityRecord->userActivity->browser;

				foreach ($activityRecord->activityDetails as $detailRecord)
				{
					$detail = new ActivityDetailModel();
					$detail->tag = $detailRecord->tag;
					$detail->value = $detailRecord->data;
					$model->details[] = $detail;
				}

				$result[] = $model;
			}

			return $result;
		}

		/**
		 * @param $activityType string
		 * @param $activitySubType string
		 * @param $activityDetails array
		 */
		public static function WriteActivity($activityType, $activitySubType, $activityDetails)
		{
			$id = uniqid();
			$activityRecord = new ActivityRecord();
			$activityRecord->id = $id;
			$activityRecord->date_time = date(Yii::app()->params['mysqlDateFormat'], time());
			$activityRecord->type = $activityType;
			$activityRecord->sub_type = $activitySubType;
			$activityRecord->save();

			ActivityUserRecord::WriteUserDetail($id);
			ActivityDetailRecord::WriteActivityDetails($id, $activityDetails);
		}
	}
