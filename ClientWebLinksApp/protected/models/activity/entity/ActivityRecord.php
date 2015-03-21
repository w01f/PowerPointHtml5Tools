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
				'groupActivities' => array(self::HAS_MANY, 'StatisticGroupRecord', 'id_activity'),
				'activityDetails' => array(self::HAS_MANY, 'ActivityDetailRecord', 'id_activity'),
			);
		}

		/**
		 * @param $startDate
		 * @param $endDate
		 * @return array
		 */
		public function findByDateRange($startDate, $endDate)
		{
			$criteria = new CDbCriteria;
			$criteria->condition = 'date_time>=:start and date_time<=:end';
			$criteria->params = array(':start' => date(Yii::app()->params['mysqlDateFormat'], strtotime($startDate)), ':end' => date(Yii::app()->params['mysqlDateFormat'], strtotime($endDate)));
			return $this->with('userActivity', 'groupActivities', 'activityDetails')->findAll($criteria);
		}

		/**
		 * @param $activityType string
		 * @param $activitySubType string
		 * @param $activityData array
		 */
		public static function WriteActivity($activityType, $activitySubType, $activityData)
		{
			$id = uniqid();
			$activityRecord = new ActivityRecord();
			$activityRecord->id = $id;
			$activityRecord->date_time = date(Yii::app()->params['mysqlDateFormat'], time());
			$activityRecord->type = $activityType;
			$activityRecord->sub_type = $activitySubType;
			$activityRecord->save();

			ActivityUserRecord::WriteUserDetail($id);
			ActivityDetailRecord::WriteActivityDetail($id, $activityData);
		}
	}
