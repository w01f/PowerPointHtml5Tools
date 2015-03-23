<?php

	/** Class RestController */
	class RestController extends CController
	{
		/**
		 * @param int $status
		 * @param mixed $data
		 */
		protected function renderJSON($status, $data = null)
		{
			header('Content-type: application/json');
			if ($status != 200)
				$data = new ResponseErrorData($status, $data);
			echo CJSON::encode(array(
				'status' => $status,
				'data' => CJSON::encode($data)
			));
			foreach (Yii::app()->log->routes as $route)
			{
				if ($route instanceof CWebLogRoute)
				{
					$route->enabled = false;
				}
			}
			Yii::app()->end();
		}
	}