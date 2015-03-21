<?php
	return array(
		'basePath' => dirname(__FILE__) . DIRECTORY_SEPARATOR . '..',
		'name' => 'Client Web Links',
		'defaultController' => 'site',
		'preload' => array('log'),
		'import' => array(
			'application.models.activity.entity.*',
			'application.models.activity.model.*',
		),
		'components' => array(
			'session' => array(
				'autoStart' => true,
			),
			'errorHandler' => array(
				'errorAction' => 'site/error',
			),
			'urlManager' => array(
				'urlFormat' => 'path',
				'showScriptName' => false,
				'rules' => array(
					'<controller:\w+>/<id:\d+>' => '<controller>/view',
					'<controller:\w+>/<action:\w+>' => '<controller>/<action>',
				)
			),
			'log' => array(
				'class' => 'CLogRouter',
				'routes' => array(
					array(
						'class' => 'CFileLogRoute',
						'levels' => 'error, warning',
					),
				),
			),
			'browser' => array(
				'class' => 'application.extensions.browser.CBrowserComponent',
			),
			'email' => array(
				'class' => 'application.extensions.email.Email',
				'delivery' => 'php',
			),
		),
		'params' => array(
			'appRoot' => dirname(__FILE__) . DIRECTORY_SEPARATOR . '..'. DIRECTORY_SEPARATOR . '..',
			'mysqlDateFormat'=>'Y-m-d H:i:s',
		),
	);