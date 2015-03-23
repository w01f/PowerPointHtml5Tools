<?

	/**
	 * Class ResponseErrorData
	 */
	class ResponseErrorData
	{
		public $code;
		public $message;
		public $details;

		/**
		 * @param int $code
		 * @param mixed $details
		 */
		public function __construct($code, $details = null)
		{
			$this->code = $code;
			$this->message = $this->_getStatusCodeMessage($code);
			$this->details = $details;
		}

		/**
		 * @param int $status
		 * @return string
		 */
		private function _getStatusCodeMessage($status)
		{
			// these could be stored in a .ini file and loaded
			// via parse_ini_file()... however, this will suffice
			// for an example
			$codes = Array(
				ResponseCode::$OK => 'OK',
				ResponseCode::$BadRequest => 'Bad Request',
				ResponseCode::$Unauthorized => 'Unauthorized',
				ResponseCode::$PaymentRequired => 'Payment Required',
				ResponseCode::$Forbidden => 'Forbidden',
				ResponseCode::$NotFound => 'Not Found',
				ResponseCode::$ServerError => 'Internal Server Error',
				ResponseCode::$NotImplemented => 'Not Implemented',
			);
			return (isset($codes[$status])) ? $codes[$status] : '';
		}
	}