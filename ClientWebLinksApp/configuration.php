<?php
	$webRoot = dirname(__FILE__);
	if ($_SERVER['HTTP_HOST'] == 'localhost')
		$internalConfig = $webRoot . '/protected/config/development.php';
	else
		$internalConfig = $webRoot . '/protected/config/production.php';

	return CMap::mergeArray(
		require($internalConfig), array(
			'name' => 'This is custom site name',
			'params' => array(
				'email' => array(
					'from' => 'clientweblink@adSALESapps.com',
				),
			),
			'components' => array(
				'db' => array(
					'connectionString' => 'mysql:host=localhost;dbname=cwl_db',
					'username' => 'root',
					'password' => 'root',
				),
			),
		)
	);
?>