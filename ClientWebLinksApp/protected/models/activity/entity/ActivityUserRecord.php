<?php

	/**
	 * Class ActivityUserRecord
	 * @property string id_activity
	 * @property mixed login
	 * @property mixed first_name
	 * @property mixed last_name
	 * @property mixed email
	 * @property mixed phone
	 * @property mixed ip
	 * @property string device
	 * @property string os
	 * @property string browser
	 */
	class ActivityUserRecord extends CActiveRecord
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
			return '{{activity_user}}';
		}

		/**
		 * @param $activityId string
		 */
		public static function WriteUserDetail($activityId)
		{
			$detailRecord = new ActivityUserRecord();
			$detailRecord->id_activity = $activityId;
			/** @var $platform string */
			$platform = Yii::app()->browser->getPlatform();
			/** @var $browser string */
			$browser = Yii::app()->browser->getBrowser();
			switch ($platform)
			{
				case Browser::PLATFORM_IPHONE:
				case Browser::PLATFORM_IPOD:
				case Browser::PLATFORM_IPAD:
					$detailRecord->device = $platform;
					$detailRecord->os = 'iOS';
					break;
				case Browser::PLATFORM_BLACKBERRY:
					$detailRecord->device = $platform;
					$detailRecord->os = $platform;
					break;
				case Browser::PLATFORM_ANDROID:
					$detailRecord->device = $platform;
					$detailRecord->os = $platform;
					break;
				case Browser::PLATFORM_APPLE:
					$detailRecord->device = 'Mac';
					$detailRecord->os = 'iOS';
					break;
				default:
					$detailRecord->device = 'PC';
					$detailRecord->os = $platform;
			}
			$detailRecord->browser = $browser;
			$detailRecord->ip = Yii::app()->request->getUserHostAddress();
			$detailRecord->save();
		}
	}
