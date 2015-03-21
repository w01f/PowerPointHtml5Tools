DROP TABLE IF EXISTS `tbl_activity_user`;
CREATE TABLE IF NOT EXISTS `tbl_activity_user` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `id_activity` varchar(32) NOT NULL,
  `ip` varchar(64) DEFAULT NULL,
  `os` varchar(256) DEFAULT NULL,
  `device` varchar(256) DEFAULT NULL,
  `browser` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_statistic` (`id_activity`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;