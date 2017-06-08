-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.6.13 - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for measurement
CREATE DATABASE IF NOT EXISTS `measurement` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `measurement`;

-- Dumping structure for table measurement.measuringdata
CREATE TABLE IF NOT EXISTS `measuringdata` (
  `DataCompleteTime` datetime DEFAULT CURRENT_TIMESTAMP,
  `LevelStatus` varchar(50) DEFAULT '',
  `TankLevel` double DEFAULT '-1',
  `AccLevelTime` datetime DEFAULT CURRENT_TIMESTAMP,
  `PressStatus` varchar(50) DEFAULT '',
  `TankPress` double DEFAULT '-1',
  `AccPressTime` datetime DEFAULT CURRENT_TIMESTAMP,
  `TempStatus` varchar(50) DEFAULT '',
  `TankTemp` double DEFAULT '-1',
  `AccTempTime` datetime DEFAULT CURRENT_TIMESTAMP,
  `KgLiquid` double DEFAULT '0',
  `KgVapour` double DEFAULT '0',
  `KgTotal` double DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
