<?php

	/**
	 * Class ActivityDetailRecord
	 * @property string id_activity
	 * @property string tag
	 * @property mixed data
	 */
	class ActivityDetailRecord extends CActiveRecord
	{
		/**
		 * @param string $className
		 * @return CActiveRecord
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
			return '{{activity_detail}}';
		}

		/**
		 * @param $activityId string
		 * @param $activityDetails array
		 */
		public static function WriteActivityDetails($activityId, $activityDetails)
		{
			if (isset($activityDetails) && is_array($activityDetails))
			{
				foreach ($activityDetails as $tag => $data)
				{
					if (isset($data))
					{
						$detailRecord = new ActivityDetailRecord();
						$detailRecord->id_activity = $activityId;
						$detailRecord->tag = $tag;
						$detailRecord->data = trim(str_replace('<br>', '', str_replace('</b>', '', str_replace('<b>', '', $data))));
						$detailRecord->save();
					}
				}
			}
		}
	}
