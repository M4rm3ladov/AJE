/*
SQLyog Enterprise - MySQL GUI v8.18 
MySQL - 5.5.5-10.1.34-MariaDB : Database - aje_pos
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`aje_pos` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `aje_pos`;

/*Table structure for table `branch` */

DROP TABLE IF EXISTS `branch`;

CREATE TABLE `branch` (
  `branch_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `branch_address` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

/*Data for the table `branch` */

insert  into `branch`(`branch_id`,`branch_address`) values (1,'Putik'),(2,'Hawaii'),(3,'Tetuan'),(5,'GUIWAN'),(6,'San Ramon'),(7,'Gotham'),(8,'Disney');

/*Table structure for table `brand` */

DROP TABLE IF EXISTS `brand`;

CREATE TABLE `brand` (
  `brand_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `brand_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`brand_id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4;

/*Data for the table `brand` */

insert  into `brand`(`brand_id`,`brand_name`) values (1,'FEDERAL'),(2,'EVERGREEN'),(3,'GOTYRE'),(4,'DURUN'),(5,'CEAT'),(6,'XCEED'),(7,'MEGA'),(8,'COMFORSER'),(9,'RADAR'),(10,'GAJAH TUNGAL'),(11,'GOODYEAR'),(12,'HANKOOK'),(13,'COCA COLA'),(15,'FANTA'),(16,'TANDUAY'),(17,'SAN MIGUEL'),(18,'RED HORSE');

/*Table structure for table `cash_in` */

DROP TABLE IF EXISTS `cash_in`;

CREATE TABLE `cash_in` (
  `cash_in_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `cashier_id` bigint(20) DEFAULT NULL,
  `manager_id` bigint(20) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cash_in_id`),
  KEY `manager_id` (`manager_id`),
  KEY `cashier_id` (`cashier_id`),
  CONSTRAINT `cash_in_ibfk_2` FOREIGN KEY (`manager_id`) REFERENCES `manager` (`manager_id`),
  CONSTRAINT `cash_in_ibfk_3` FOREIGN KEY (`cashier_id`) REFERENCES `cashier` (`cashier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `cash_in` */

/*Table structure for table `cash_out` */

DROP TABLE IF EXISTS `cash_out`;

CREATE TABLE `cash_out` (
  `cash_out_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `cashier_id` bigint(20) DEFAULT NULL,
  `manager_id` bigint(20) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cash_out_id`),
  KEY `manager_id` (`manager_id`),
  KEY `cashier_id` (`cashier_id`),
  CONSTRAINT `cash_out_ibfk_2` FOREIGN KEY (`manager_id`) REFERENCES `manager` (`manager_id`),
  CONSTRAINT `cash_out_ibfk_3` FOREIGN KEY (`cashier_id`) REFERENCES `cashier` (`cashier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `cash_out` */

/*Table structure for table `cash_payment` */

DROP TABLE IF EXISTS `cash_payment`;

CREATE TABLE `cash_payment` (
  `cash_pay_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `order_id` bigint(20) DEFAULT NULL,
  `cashier_id` bigint(20) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `pay_amount` decimal(15,2) DEFAULT NULL,
  `receipt` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cash_pay_id`),
  KEY `cashier_id` (`cashier_id`),
  KEY `order_id` (`order_id`),
  CONSTRAINT `cash_payment_ibfk_1` FOREIGN KEY (`cashier_id`) REFERENCES `cashier` (`cashier_id`),
  CONSTRAINT `cash_payment_ibfk_2` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cash_payment` */

insert  into `cash_payment`(`cash_pay_id`,`order_id`,`cashier_id`,`trans_date`,`pay_amount`,`receipt`) values (1,2,2,'2020-04-15','5000.00','492910881'),(2,3,2,'2020-06-03','3000.00','25000210'),(3,4,6,'2020-06-03','28000.00','250001002');

/*Table structure for table `cashier` */

DROP TABLE IF EXISTS `cashier`;

CREATE TABLE `cashier` (
  `cashier_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `user_id` bigint(20) DEFAULT NULL,
  `username` varbinary(30) DEFAULT NULL,
  `password` varbinary(100) DEFAULT NULL,
  `salt` varbinary(100) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  `is_logged_in` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`cashier_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `cashier_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cashier` */

insert  into `cashier`(`cashier_id`,`user_id`,`username`,`password`,`salt`,`is_active`,`is_logged_in`) values (1,1,'antonio123','FC0mMV3Ym0dHzkrCDSfPyeRNzwEdrBZ1M3wPT0CMKBo=','j50mMYhR+NqDEsvL8tc4ud0g/mVvk7qNACzmR0vilw4=',1,0),(2,4,'renier1234','EV0xZf+XtQmppLIEoJADJb9QwRdYOFGP5mrUF51ZPkU=','hDLxLCltP+KbVa73iJguzZsgspj/qDvZwfcETu84Bjs=',1,1),(4,8,'B0n1fac10','H1VNKW5Uh0SVdFLccu7jCw9emGkYFGgvU3Flo4Qfxh0=','xhuQwdGK05E44UXhtGbAFZyKBzAp3EVv06VHGtI6nLY=',1,0),(5,7,'Louise123','6Hp/mP6sqJKyVb27xwEPOpIAIAc10BLKUcAMFCySSAo=','2y2y8LTz0BayCWghNOYpM01VIKhuHSAbp/BKYuF4Itc=',1,0),(6,11,'Hellow','Kn8eB0Lp1I1PpvKc+XxgXuzqjDt5cxFnTbk1HrwdFz8=','QrNvzcTgeFVoc8As2ptD5s8NRkueEXVvHbCYWZZPsZA=',1,0),(7,12,'Mary123','7kxHlPgi+1whYcfOPkxmJEiftMKBMWRZcTDhNzq4qpo=','QCsQzPDirPngYM5dugADV7T9/nSxTv7uAF8qzipUniQ=',1,0),(8,14,'Betty123','1F4xWTa2Pbm3XTRFJh/QImsfAeX/R9GJt0Qx8y9ir6Q=','q6BuDOypWpplcFtP17wLh+ziUJA4rxJ2ULjNXW4rlyI=',1,0);

/*Table structure for table `cashier_log` */

DROP TABLE IF EXISTS `cashier_log`;

CREATE TABLE `cashier_log` (
  `cashier_log_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `cashier_id` bigint(20) DEFAULT NULL,
  `manager_id` bigint(20) DEFAULT NULL,
  `log_date` date DEFAULT NULL,
  `time_from` time DEFAULT NULL,
  `time_to` time DEFAULT NULL,
  `begin_bal` decimal(15,2) DEFAULT NULL,
  `end_bal` decimal(15,2) DEFAULT '0.00',
  PRIMARY KEY (`cashier_log_id`),
  KEY `manager_id` (`manager_id`),
  KEY `cashier_id` (`cashier_id`),
  CONSTRAINT `cashier_log_ibfk_2` FOREIGN KEY (`manager_id`) REFERENCES `manager` (`manager_id`),
  CONSTRAINT `cashier_log_ibfk_3` FOREIGN KEY (`cashier_id`) REFERENCES `cashier` (`cashier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cashier_log` */

insert  into `cashier_log`(`cashier_log_id`,`cashier_id`,`manager_id`,`log_date`,`time_from`,`time_to`,`begin_bal`,`end_bal`) values (1,1,2,'2020-04-17','12:58:02',NULL,'2850.00','0.00'),(2,1,2,'2020-04-17','13:06:32',NULL,'200.00','0.00'),(3,2,2,'2020-04-17','13:23:57','00:05:31','500.00','500.00'),(4,1,2,'2020-04-17','13:34:12',NULL,'5002.00','0.00'),(5,1,2,'2020-04-17','13:40:39',NULL,'5020.00','0.00'),(6,1,2,'2020-04-17','13:45:33',NULL,'600.00','0.00'),(7,1,2,'2020-04-17','18:44:45',NULL,'200.00','0.00'),(8,2,2,'2020-04-17','18:48:33','00:05:31','2100.00','500.00'),(9,1,2,'2020-04-17','19:19:39',NULL,'200.00','0.00'),(10,2,2,'2020-04-17','19:20:05','00:05:31','5000.00','500.00'),(11,1,2,'2020-04-18','14:50:43',NULL,'3000.00','0.00'),(12,2,2,'2020-04-18','14:53:40','00:05:31','200.00','500.00'),(13,1,2,'2020-04-18','14:54:30',NULL,'2003.04','0.00'),(14,2,2,'2020-04-18','14:58:19','00:05:31','2500.00','500.00'),(15,1,2,'2020-04-18','15:13:30',NULL,'2000.00','0.00'),(16,1,2,'2020-04-18','15:22:41',NULL,'250.00','0.00'),(17,1,2,'2020-04-22','11:50:25',NULL,'1200.00','0.00'),(18,1,2,'2020-04-22','13:57:11',NULL,'2000.00','0.00'),(19,2,2,'2020-04-22','14:04:06','00:05:31','1250.00','500.00'),(20,1,2,'2020-04-22','14:07:18',NULL,'5200.00','0.00'),(21,2,2,'2020-04-22','14:08:22','00:05:31','3000.00','500.00'),(22,1,2,'2020-04-23','13:17:23',NULL,'20.00','0.00'),(23,1,2,'2020-04-23','13:19:28',NULL,'4050.00','0.00'),(24,1,2,'2020-04-25','16:21:04',NULL,'2000.00','0.00'),(25,1,2,'2020-04-25','16:27:11',NULL,'2500.00','0.00'),(26,2,2,'2020-05-02','22:55:31','00:05:31','5000.00','500.00'),(27,1,2,'2020-05-05','14:20:06',NULL,'5400.00','0.00'),(28,1,2,'2020-05-09','14:08:21',NULL,'2500.00','0.00'),(29,1,2,'2020-05-09','14:14:24',NULL,'2500.00','0.00'),(30,1,2,'2020-05-09','14:25:47',NULL,'2500.00','0.00'),(31,2,2,'2020-05-09','14:28:48','00:05:31','5600.00','500.00'),(32,2,2,'2020-05-09','14:32:06','00:05:31','5000.00','500.00'),(33,2,2,'2020-05-09','14:33:27','00:05:31','2500.00','500.00'),(34,2,2,'2020-05-09','14:47:12','00:05:31','2500.00','500.00'),(35,2,2,'2020-05-09','14:50:04','00:05:31','250.00','500.00'),(36,2,2,'2020-05-09','14:52:43','00:05:31','250.00','500.00'),(37,2,2,'2020-05-09','14:59:49','00:05:31','2500.00','500.00'),(38,2,2,'2020-05-15','15:44:22','00:05:31','3400.00','500.00'),(39,2,2,'2020-05-15','15:54:37','00:05:31','2500.00','500.00'),(40,2,2,'2020-05-15','16:03:19','00:05:31','2500.00','500.00'),(41,2,2,'2020-05-15','16:06:41','00:05:31','2500.00','500.00'),(42,2,2,'2020-05-15','16:09:53','00:05:31','2500.00','500.00'),(43,2,2,'2020-05-15','16:15:11','00:05:31','250.00','500.00'),(44,2,2,'2020-05-15','16:18:25','00:05:31','2500.00','500.00'),(45,2,2,'2020-05-15','16:22:14','00:05:31','2500.00','500.00'),(46,2,2,'2020-05-15','16:23:45','00:05:31','250.00','500.00'),(47,2,2,'2020-05-15','17:11:23','00:05:31','2500.00','500.00'),(48,2,2,'2020-05-15','17:15:43','00:05:31','3500.00','500.00'),(49,2,2,'2020-05-15','17:22:34','00:05:31','2500.00','500.00'),(50,2,2,'2020-05-15','17:25:53','00:05:31','2500.00','500.00'),(51,2,2,'2020-05-15','17:26:56','00:05:31','2500.00','500.00'),(52,2,2,'2020-05-15','17:28:45','00:05:31','25000.00','500.00'),(53,2,2,'2020-05-15','17:31:48','00:05:31','2500.00','500.00'),(54,2,2,'2020-05-15','17:34:39','00:05:31','0.00','500.00'),(55,2,2,'2020-05-15','19:28:20','00:05:31','2500.00','500.00'),(56,2,2,'2020-05-15','19:33:52','00:05:31','5300.00','500.00'),(57,1,2,'2020-05-17','13:27:13',NULL,'2500.00','0.00'),(58,1,2,'2020-05-17','13:51:38',NULL,'5000.00','0.00'),(59,2,2,'2020-06-02','16:09:45','00:05:31','2500.00','500.00'),(60,1,2,'2020-06-02','16:57:27',NULL,'2300.00','0.00'),(61,2,2,'2020-06-02','16:58:28','00:05:31','2344.44','500.00'),(62,2,2,'2020-06-02','17:17:38','00:05:31','2000.00','500.00'),(63,2,1,'2020-06-02','23:35:26','00:05:31','2500.00','500.00'),(64,2,1,'2020-06-03','15:52:17','00:05:31','5000.00','500.00'),(65,2,1,'2020-06-03','17:20:39','00:05:31','5000.00','500.00'),(66,2,2,'2020-06-03','17:28:16','00:05:31','2000.00','500.00'),(67,2,1,'2020-06-03','18:52:17','00:05:31','2000.00','500.00'),(68,6,1,'2020-06-03','20:19:04',NULL,'2000.00','0.00'),(69,6,3,'2020-06-03','20:26:07',NULL,'5000.00','0.00'),(70,6,1,'2020-06-04','20:49:02',NULL,'2000.00','0.00'),(71,6,1,'2020-06-04','20:57:27',NULL,'2000.00','0.00'),(72,2,1,'2020-06-07','17:02:46','00:05:31','2000.00','500.00'),(73,2,1,'2020-06-07','17:09:28','00:05:31','300.00','500.00'),(74,2,1,'2020-06-07','17:11:59','00:05:31','210.00','500.00'),(75,2,2,'2020-06-07','17:13:48','00:05:31','210.00','500.00'),(76,2,2,'2020-06-07','17:16:38','00:05:31','2100.00','500.00'),(77,2,1,'2020-06-23','20:05:42','00:05:31','4000.00','500.00'),(78,2,1,'2020-06-23','21:59:06','00:05:31','4000.00','500.00'),(79,2,2,'2020-06-23','22:00:14','00:05:31','4000.00','500.00'),(80,2,2,'2020-06-23','22:02:18','00:05:31','200.00','500.00'),(81,2,2,'2020-06-23','22:06:35','00:05:31','540.00','500.00'),(82,2,2,'2020-06-23','22:10:46','00:05:31','430.00','500.00'),(83,2,2,'2020-06-23','22:13:31','00:05:31','520.00','500.00'),(84,2,2,'2020-06-23','22:58:48','00:05:31','2000.00','500.00'),(85,2,2,'2020-06-23','23:30:58','00:05:31','3000.00','500.00'),(86,2,2,'2020-06-23','23:57:12','00:05:31','200.00','500.00'),(87,2,2,'2020-06-23','23:58:07','00:05:31','200.05','500.00'),(88,2,2,'2020-06-23','23:59:21','00:05:31','5000.00','500.00'),(89,2,2,'2020-06-24','00:05:29','00:05:31','2500.00','500.00'),(90,2,2,'2020-06-24','00:14:16',NULL,'1000.00','0.00'),(91,2,2,'2020-06-24','00:22:11',NULL,'9000.00','0.00'),(92,2,2,'2020-06-24','00:38:50',NULL,'600.50','0.00'),(93,2,2,'2020-06-24','00:39:57',NULL,'230.00','0.00'),(94,2,2,'2020-06-24','00:40:54',NULL,'53.20','0.00'),(95,2,2,'2020-06-24','00:42:01',NULL,'230.00','0.00'),(96,2,2,'2020-06-24','00:42:58',NULL,'43.00','0.00'),(97,2,2,'2020-06-24','00:44:07','00:44:12','53.00','0.00'),(98,2,2,'2020-06-24','00:55:48','00:55:54','39.99','39.99'),(99,2,2,'2020-06-24','15:40:02',NULL,'2300.00','0.00'),(100,7,2,'2020-06-24','15:50:17','15:51:39','400.00','400.00'),(101,7,2,'2020-06-24','17:15:50','17:17:51','250.00','250.00'),(102,8,2,'2020-06-24','17:59:47',NULL,'2300.00','0.00'),(103,8,2,'2020-06-24','18:34:25','19:54:32','220.00','220.00'),(104,8,2,'2020-06-24','19:58:14','20:32:47','200.05','170.05');

/*Table structure for table `category` */

DROP TABLE IF EXISTS `category`;

CREATE TABLE `category` (
  `category_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `category_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

/*Data for the table `category` */

insert  into `category`(`category_id`,`category_name`) values (2,'BRAND NEW WHEEL'),(3,'USED WHEEL'),(6,'SOFT DRINKS'),(7,'OIL'),(8,'BOLT'),(9,'ALCOHOLIC DRINK');

/*Table structure for table `credit_payment` */

DROP TABLE IF EXISTS `credit_payment`;

CREATE TABLE `credit_payment` (
  `credit_pay_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `order_id` bigint(20) DEFAULT NULL,
  `cashier_id` bigint(20) DEFAULT NULL,
  `customer_id` bigint(20) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `pay_amount` decimal(15,2) DEFAULT NULL,
  `invoice` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`credit_pay_id`),
  KEY `cashier_id` (`cashier_id`),
  KEY `customer_id` (`customer_id`),
  KEY `order_id` (`order_id`),
  CONSTRAINT `credit_payment_ibfk_1` FOREIGN KEY (`cashier_id`) REFERENCES `cashier` (`cashier_id`),
  CONSTRAINT `credit_payment_ibfk_2` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`),
  CONSTRAINT `credit_payment_ibfk_3` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `credit_payment` */

insert  into `credit_payment`(`credit_pay_id`,`order_id`,`cashier_id`,`customer_id`,`trans_date`,`pay_amount`,`invoice`) values (1,1,2,2,'2020-04-17','2700.00','5923417'),(2,5,6,5,'2020-06-04','500.00','50100010'),(3,7,8,7,'2020-06-24','20000.00','09101989178');

/*Table structure for table `credit_settle` */

DROP TABLE IF EXISTS `credit_settle`;

CREATE TABLE `credit_settle` (
  `credit_settle_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `customer_id` bigint(20) DEFAULT NULL,
  `cashier_id` bigint(20) DEFAULT NULL,
  `manager_id` bigint(20) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `pay_amount` decimal(15,2) DEFAULT NULL,
  `receipt` bigint(10) DEFAULT NULL,
  PRIMARY KEY (`credit_settle_id`),
  KEY `customer_id` (`customer_id`),
  KEY `cashier_id` (`cashier_id`),
  KEY `manager_id` (`manager_id`),
  CONSTRAINT `credit_settle_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`),
  CONSTRAINT `credit_settle_ibfk_2` FOREIGN KEY (`cashier_id`) REFERENCES `cashier` (`cashier_id`),
  CONSTRAINT `credit_settle_ibfk_3` FOREIGN KEY (`manager_id`) REFERENCES `manager` (`manager_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `credit_settle` */

insert  into `credit_settle`(`credit_settle_id`,`customer_id`,`cashier_id`,`manager_id`,`trans_date`,`pay_amount`,`receipt`) values (1,2,2,2,'2020-04-17','3000.00',2501321),(2,5,6,3,'2020-06-04','200.00',200012010),(3,7,8,2,'2020-06-25','10000.00',2102391089);

/*Table structure for table `customer` */

DROP TABLE IF EXISTS `customer`;

CREATE TABLE `customer` (
  `customer_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `customer_code` varchar(30) DEFAULT NULL,
  `credit_limit` decimal(15,2) DEFAULT '0.00',
  `balance` decimal(15,2) DEFAULT '0.00',
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

/*Data for the table `customer` */

insert  into `customer`(`customer_id`,`customer_code`,`credit_limit`,`balance`) values (1,'CUST-001','100.00','0.00'),(2,'CUST-002','3000.00','2700.00'),(3,'CUST-003','5000.00','0.00'),(4,'CUST-004','50000.00','0.00'),(5,'CUST-005','10000.00','300.00'),(6,'CUST-006','10000.00','0.00'),(7,'CUST-007','20000.00','9530.00');

/*Table structure for table `customer_details` */

DROP TABLE IF EXISTS `customer_details`;

CREATE TABLE `customer_details` (
  `customer_id` bigint(20) DEFAULT NULL,
  `customer_surname` varchar(30) DEFAULT NULL,
  `customer_gname` varchar(30) DEFAULT NULL,
  `customer_mi` varchar(10) DEFAULT NULL,
  `customer_suffix` varchar(10) DEFAULT NULL,
  KEY `customer_id` (`customer_id`),
  CONSTRAINT `customer_details_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `customer_details` */

insert  into `customer_details`(`customer_id`,`customer_surname`,`customer_gname`,`customer_mi`,`customer_suffix`) values (1,'Antonio','Renier','',''),(2,'Antonio','Zoren','F.',''),(3,'KREME','KRISPY','',''),(4,'Stark','Tony','',''),(5,'Panther','Tchalla','',''),(6,'Wayne','Bruce','',''),(7,'Parker','Peter','','');

/*Table structure for table `inventory` */

DROP TABLE IF EXISTS `inventory`;

CREATE TABLE `inventory` (
  `inventory_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `item_id` bigint(20) DEFAULT NULL,
  `branch_id` bigint(20) DEFAULT NULL,
  `qty` int(11) DEFAULT '0',
  PRIMARY KEY (`inventory_id`),
  KEY `item_id` (`item_id`),
  KEY `branch_id` (`branch_id`),
  CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_id`),
  CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4;

/*Data for the table `inventory` */

insert  into `inventory`(`inventory_id`,`item_id`,`branch_id`,`qty`) values (1,14,3,50),(2,3,3,49),(3,5,3,48),(4,8,3,50),(5,25,6,30),(6,26,6,30),(7,15,6,40),(8,25,3,100),(9,27,7,100),(10,28,7,100),(11,25,7,100),(12,26,7,100),(13,29,8,350),(14,25,8,200),(15,26,8,5),(16,28,8,200);

/*Table structure for table `inventory_period` */

DROP TABLE IF EXISTS `inventory_period`;

CREATE TABLE `inventory_period` (
  `inv_period_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `period_from` date DEFAULT NULL,
  `period_to` date DEFAULT NULL,
  PRIMARY KEY (`inv_period_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `inventory_period` */

/*Table structure for table `item` */

DROP TABLE IF EXISTS `item`;

CREATE TABLE `item` (
  `item_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `item_code` varchar(20) DEFAULT NULL,
  `item_desc` varchar(50) DEFAULT NULL,
  `item_add_desc` varchar(50) DEFAULT NULL,
  `brand_id` bigint(20) DEFAULT NULL,
  `category_id` bigint(20) DEFAULT NULL,
  `unit_id` bigint(20) DEFAULT NULL,
  `item_unit_price` decimal(15,2) DEFAULT NULL,
  `item_price_A` decimal(15,2) DEFAULT NULL,
  `item_price_B` decimal(15,2) DEFAULT NULL,
  PRIMARY KEY (`item_id`),
  KEY `brand_id` (`brand_id`),
  KEY `category_id` (`category_id`),
  KEY `unit_id` (`unit_id`),
  CONSTRAINT `item_ibfk_1` FOREIGN KEY (`brand_id`) REFERENCES `brand` (`brand_id`),
  CONSTRAINT `item_ibfk_2` FOREIGN KEY (`category_id`) REFERENCES `category` (`category_id`),
  CONSTRAINT `item_ibfk_3` FOREIGN KEY (`unit_id`) REFERENCES `unit` (`unit_id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4;

/*Data for the table `item` */

insert  into `item`(`item_id`,`item_code`,`item_desc`,`item_add_desc`,`brand_id`,`category_id`,`unit_id`,`item_unit_price`,`item_price_A`,`item_price_B`) values (1,'ITEM-001','ECOVAN','1554 12LT 8PR',1,2,1,'2700.00','2900.00','2600.00'),(2,'ITEM-002','ES88','155R 12LT 6PR',2,3,1,'2300.00','2500.00','2400.00'),(3,'ITEM-003','LRP158','155R 12LT 8PR',3,2,1,'1850.00','2100.00','1900.00'),(4,'ITEM-004','C212','155R 12LT 8PR',4,2,1,'2300.00','2600.00','2400.00'),(5,'ITEM-005','MIXLUG','500X12 10PR',4,2,1,'2800.00','2900.00','2700.00'),(6,'ITEM-006','MILER/RIB','500X12 8PR',3,3,1,'2200.00','2300.00','2100.00'),(7,'ITEM-007','MILAZE','165/65R13',5,2,1,'2500.00','2600.00','2400.00'),(8,'ITEM-008','EH22','165/65R13',2,2,1,'2450.00','2500.00','2400.00'),(9,'ITEM-009','MILAZE','165/65R13',5,3,1,'2500.00','2600.00','2400.00'),(10,'ITEM-010','EH22','165/65R13',2,3,1,'2450.00','2500.00','2400.00'),(11,'ITEM-011','CF610','165/65R13',8,3,1,'2300.00','2400.00','2200.00'),(12,'ITEM-012','RPX900','165 65R13',9,2,1,'2500.00','2600.00','2400.00'),(13,'ITEM-013','T90A','165/65R13',4,2,1,'2500.00','2600.00','2400.00'),(14,'ITEM-014','RPX9001','165 65R13',9,2,1,'2500.00','2600.00','2400.00'),(15,'ITEM-14321','AFASDFA','ASFASDF',13,2,2,'2600.00','2700.00','2500.00'),(17,'ITEM-13212','MARCH','ARPIL',1,3,1,'2500.00','3000.00','2000.00'),(22,'ITEM-123','ECO/VAN','1554 12LT 8PR',1,2,1,'2600.00','2900.00','2700.00'),(23,'ITEM-10321','CEET','BLAZE',4,3,1,'2000.00','2500.00','1900.00'),(24,'ITEM-52121','GOTX','LB 119',4,2,1,'2500.00','3000.00','1900.00'),(25,'ITEM-023140','ICE','BLUE',16,9,2,'25.00','30.00','20.00'),(26,'ITEM-012301','ICE','PINK',16,9,2,'25.00','30.00','20.00'),(27,'ITEM-19129','LIGHT','ORIGINAL',17,9,1,'45.00','50.00','40.00'),(28,'ITEM-39491','LIGHT','APPLE',17,9,1,'45.00','50.00','40.00'),(29,'ITEM-2191','ORIG.','12 Oz.',18,9,1,'80.00','90.00','75.00');

/*Table structure for table `manager` */

DROP TABLE IF EXISTS `manager`;

CREATE TABLE `manager` (
  `manager_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `user_id` bigint(20) DEFAULT NULL,
  `username` varbinary(30) DEFAULT NULL,
  `password` varbinary(100) DEFAULT NULL,
  `salt` varbinary(100) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  `is_logged_in` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`manager_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `manager_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `manager` */

insert  into `manager`(`manager_id`,`user_id`,`username`,`password`,`salt`,`is_active`,`is_logged_in`) values (1,4,'John12345','6aIJbUr31XiovrQOaO6Evt9xjb/J7HCgH8JsMaddS90=','GxSYNJ+2OUMjLsTy1rjAY/+QjMjoTa+WfY7Ty8M7iMc=',1,0),(2,6,'W4d3yyy','ieAgkbRFaDOsy88sP0APSXuCWe6yNx9Uz6TAL5ubNJY=','HKYb/kb7/bxP8qxXfIRn+m9q+W6sN+uSEMe3AbZpNkM=',1,0),(3,10,'BruceBruce','QVT8DRN+Ra7yknppOIlq7wMj0zUSeVb4u+W1Ye7v1vI=','GVGPcme74GR+U5+mgHuGo+Ad9hkagA+6EuXJ6aoUJ/w=',1,0);

/*Table structure for table `order_item_dtls` */

DROP TABLE IF EXISTS `order_item_dtls`;

CREATE TABLE `order_item_dtls` (
  `order_item_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `order_id` bigint(20) DEFAULT NULL,
  `inventory_id` bigint(20) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `price` decimal(15,2) DEFAULT NULL,
  `line_total` decimal(15,2) DEFAULT NULL,
  PRIMARY KEY (`order_item_id`),
  KEY `inventory_id` (`inventory_id`),
  KEY `order_id` (`order_id`),
  CONSTRAINT `order_item_dtls_ibfk_3` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`inventory_id`),
  CONSTRAINT `order_item_dtls_ibfk_4` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

/*Data for the table `order_item_dtls` */

insert  into `order_item_dtls`(`order_item_id`,`order_id`,`inventory_id`,`qty`,`price`,`line_total`) values (1,1,3,1,'2700.00','2700.00'),(2,2,2,2,'1900.00','3800.00'),(3,3,3,1,'2800.00','2800.00'),(4,4,5,10,'30.00','300.00'),(5,4,6,10,'30.00','300.00'),(6,4,7,10,'2700.00','27000.00'),(7,5,5,10,'25.00','250.00'),(8,5,6,10,'25.00','250.00'),(9,6,13,0,'90.00','150.00'),(10,7,15,201,'30.00','201.00'),(11,7,13,150,'90.00','150.00');

/*Table structure for table `order_svc_dtls` */

DROP TABLE IF EXISTS `order_svc_dtls`;

CREATE TABLE `order_svc_dtls` (
  `order_svc_dtls` bigint(20) NOT NULL AUTO_INCREMENT,
  `order_id` bigint(20) DEFAULT NULL,
  `service_id` bigint(20) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `price` decimal(15,2) DEFAULT NULL,
  `line_total` decimal(15,2) DEFAULT NULL,
  PRIMARY KEY (`order_svc_dtls`),
  KEY `service_id` (`service_id`),
  KEY `order_id` (`order_id`),
  CONSTRAINT `order_svc_dtls_ibfk_1` FOREIGN KEY (`service_id`) REFERENCES `service` (`service_id`),
  CONSTRAINT `order_svc_dtls_ibfk_2` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `order_svc_dtls` */

insert  into `order_svc_dtls`(`order_svc_dtls`,`order_id`,`service_id`,`qty`,`price`,`line_total`) values (1,2,1,2,'200.00','400.00');

/*Table structure for table `orders` */

DROP TABLE IF EXISTS `orders`;

CREATE TABLE `orders` (
  `order_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `trans_date` date DEFAULT NULL,
  `gross_amount` decimal(15,2) DEFAULT NULL,
  `trans_code` bigint(10) DEFAULT NULL,
  `branch_id` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  KEY `branch_id` (`branch_id`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

/*Data for the table `orders` */

insert  into `orders`(`order_id`,`trans_date`,`gross_amount`,`trans_code`,`branch_id`) values (1,'2020-04-17','2700.00',1,3),(2,'2020-04-17','4200.00',1,3),(3,'2020-06-03','2800.00',1,3),(4,'2020-06-03','27600.00',1,6),(5,'2020-06-04','500.00',1,6),(6,'2020-06-24','19530.00',1,8),(7,'2020-06-24','19530.00',1,8);

/*Table structure for table `physical_count` */

DROP TABLE IF EXISTS `physical_count`;

CREATE TABLE `physical_count` (
  `phys_count_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `inv_period_id` bigint(20) DEFAULT NULL,
  `inventory_id` bigint(20) DEFAULT NULL,
  `qty` int(11) DEFAULT '0',
  `count_date` date DEFAULT NULL,
  `ref_no` bigint(10) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`phys_count_id`),
  KEY `inventory_id` (`inventory_id`),
  KEY `inv_period_id` (`inv_period_id`),
  CONSTRAINT `physical_count_ibfk_4` FOREIGN KEY (`inv_period_id`) REFERENCES `inventory_period` (`inv_period_id`),
  CONSTRAINT `physical_count_ibfk_5` FOREIGN KEY (`inv_period_id`) REFERENCES `inventory` (`inventory_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `physical_count` */

/*Table structure for table `refund` */

DROP TABLE IF EXISTS `refund`;

CREATE TABLE `refund` (
  `refund_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `order_id` bigint(20) DEFAULT NULL,
  `cashier_id` bigint(20) DEFAULT NULL,
  `manager_id` bigint(20) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`refund_id`),
  KEY `manager_id` (`manager_id`),
  KEY `order_id` (`order_id`),
  KEY `cashier_id` (`cashier_id`),
  CONSTRAINT `refund_ibfk_2` FOREIGN KEY (`manager_id`) REFERENCES `manager` (`manager_id`),
  CONSTRAINT `refund_ibfk_3` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`),
  CONSTRAINT `refund_ibfk_4` FOREIGN KEY (`cashier_id`) REFERENCES `cashier` (`cashier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `refund` */

insert  into `refund`(`refund_id`,`order_id`,`cashier_id`,`manager_id`,`amount`,`trans_date`,`remarks`) values (1,2,2,2,'1800.00','2020-05-15','eyooo!'),(2,7,8,2,'30.00','2020-06-24','etc.');

/*Table structure for table `refund_item_dtls` */

DROP TABLE IF EXISTS `refund_item_dtls`;

CREATE TABLE `refund_item_dtls` (
  `refund_item_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `refund_id` bigint(20) DEFAULT NULL,
  `inventory_id` bigint(20) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `price` decimal(15,2) DEFAULT NULL,
  `sub_total` decimal(15,2) DEFAULT NULL,
  PRIMARY KEY (`refund_item_id`),
  KEY `refund_id` (`refund_id`),
  KEY `inventory_id` (`inventory_id`),
  CONSTRAINT `refund_item_dtls_ibfk_1` FOREIGN KEY (`refund_id`) REFERENCES `refund` (`refund_id`),
  CONSTRAINT `refund_item_dtls_ibfk_2` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`inventory_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `refund_item_dtls` */

insert  into `refund_item_dtls`(`refund_item_id`,`refund_id`,`inventory_id`,`qty`,`price`,`sub_total`) values (1,NULL,2,1,'1800.00','1800.00'),(2,2,15,1,'30.00','30.00');

/*Table structure for table `refund_svc_dtls` */

DROP TABLE IF EXISTS `refund_svc_dtls`;

CREATE TABLE `refund_svc_dtls` (
  `refund_svc_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `refund_id` bigint(20) DEFAULT NULL,
  `service_id` bigint(20) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `price` decimal(15,2) DEFAULT NULL,
  `sub_total` decimal(15,2) DEFAULT NULL,
  PRIMARY KEY (`refund_svc_id`),
  KEY `service_id` (`service_id`),
  KEY `refund_id` (`refund_id`),
  CONSTRAINT `refund_svc_dtls_ibfk_1` FOREIGN KEY (`service_id`) REFERENCES `service` (`service_id`),
  CONSTRAINT `refund_svc_dtls_ibfk_2` FOREIGN KEY (`refund_id`) REFERENCES `refund` (`refund_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `refund_svc_dtls` */

/*Table structure for table `service` */

DROP TABLE IF EXISTS `service`;

CREATE TABLE `service` (
  `service_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `service_code` varchar(20) DEFAULT NULL,
  `service_desc` varchar(50) DEFAULT NULL,
  `service_fee_A` decimal(15,2) DEFAULT NULL,
  `service_fee_B` decimal(15,2) DEFAULT NULL,
  PRIMARY KEY (`service_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `service` */

insert  into `service`(`service_id`,`service_code`,`service_desc`,`service_fee_A`,`service_fee_B`) values (1,'SERVICE-001','Tire Change','400.00','200.00'),(2,'SERVICE-002','OIL CHANGE','100.00','80.00');

/*Table structure for table `stock_in` */

DROP TABLE IF EXISTS `stock_in`;

CREATE TABLE `stock_in` (
  `stock_in_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `inventory_id` bigint(20) DEFAULT NULL,
  `branch_id` bigint(20) DEFAULT NULL,
  `supplier_id` bigint(20) DEFAULT NULL,
  `ref_no` bigint(10) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`stock_in_id`),
  KEY `branch_id` (`branch_id`),
  KEY `supplier_id` (`supplier_id`),
  KEY `inventory_id` (`inventory_id`),
  CONSTRAINT `stock_in_ibfk_2` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`),
  CONSTRAINT `stock_in_ibfk_3` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`supplier_id`),
  CONSTRAINT `stock_in_ibfk_4` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`inventory_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_in` */

insert  into `stock_in`(`stock_in_id`,`inventory_id`,`branch_id`,`supplier_id`,`ref_no`,`qty`,`trans_date`,`remarks`) values (1,1,3,2,1,50,'2020-03-21','initial'),(2,2,3,2,1,50,'2020-03-21','initial'),(3,3,3,2,1,50,'2020-03-21','initial'),(4,4,3,2,1,50,'2020-03-21','initial'),(5,5,6,5,2,50,'2020-03-21',''),(6,6,6,5,2,50,'2020-03-21',''),(7,7,6,5,2,50,'2020-03-21',''),(8,8,3,2,3,100,'2020-03-21',''),(9,9,7,2,4,100,'2020-03-21','initial stock in'),(10,10,7,2,4,100,'2020-03-21','initial stock in'),(11,11,7,2,4,100,'2020-03-21','initial stock in'),(12,12,7,2,4,100,'2020-03-21','initial stock in'),(13,13,8,2,5,500,'2020-03-21',''),(14,14,8,2,5,200,'2020-03-21',''),(15,15,8,2,5,200,'2020-03-21',''),(16,16,8,2,5,200,'2020-03-21',''),(17,15,8,2,6,5,'2020-03-21','');

/*Table structure for table `stock_out` */

DROP TABLE IF EXISTS `stock_out`;

CREATE TABLE `stock_out` (
  `stock_out_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `inventory_id` bigint(20) DEFAULT NULL,
  `branch_id` bigint(20) DEFAULT NULL,
  `ref_no` bigint(10) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`stock_out_id`),
  KEY `branch_id` (`branch_id`),
  KEY `inventory_id` (`inventory_id`),
  CONSTRAINT `stock_out_ibfk_2` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`),
  CONSTRAINT `stock_out_ibfk_3` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`inventory_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_out` */

/*Table structure for table `stock_return` */

DROP TABLE IF EXISTS `stock_return`;

CREATE TABLE `stock_return` (
  `stock_ret_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `inventory_id` bigint(20) DEFAULT NULL,
  `branch_id` bigint(20) DEFAULT NULL,
  `supplier_id` bigint(20) DEFAULT NULL,
  `ref_no` bigint(10) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`stock_ret_id`),
  KEY `branch_id` (`branch_id`),
  KEY `supplier_id` (`supplier_id`),
  KEY `inventory_id` (`inventory_id`),
  CONSTRAINT `stock_return_ibfk_1` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`),
  CONSTRAINT `stock_return_ibfk_2` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`supplier_id`),
  CONSTRAINT `stock_return_ibfk_3` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`inventory_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_return` */

/*Table structure for table `stock_transfer` */

DROP TABLE IF EXISTS `stock_transfer`;

CREATE TABLE `stock_transfer` (
  `stock_trans_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `inventory_id` bigint(20) DEFAULT NULL,
  `branch_id_from` bigint(20) DEFAULT NULL,
  `branch_id_to` bigint(20) DEFAULT NULL,
  `ref_no` bigint(10) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`stock_trans_id`),
  KEY `branch_id_from` (`branch_id_from`),
  KEY `branch_id_to` (`branch_id_to`),
  KEY `inventory_id` (`inventory_id`),
  CONSTRAINT `stock_transfer_ibfk_2` FOREIGN KEY (`branch_id_from`) REFERENCES `branch` (`branch_id`),
  CONSTRAINT `stock_transfer_ibfk_3` FOREIGN KEY (`branch_id_to`) REFERENCES `branch` (`branch_id`),
  CONSTRAINT `stock_transfer_ibfk_4` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`inventory_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_transfer` */

/*Table structure for table `supplier` */

DROP TABLE IF EXISTS `supplier`;

CREATE TABLE `supplier` (
  `supplier_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(50) DEFAULT NULL,
  `supplier_address` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `supplier` */

insert  into `supplier`(`supplier_id`,`supplier_name`,`supplier_address`) values (2,'DOST','Petit Barracks'),(3,'Tetuan Branch','Tetuan'),(4,'Putik Branch','Putik'),(5,'SM','talon-talon');

/*Table structure for table `unit` */

DROP TABLE IF EXISTS `unit`;

CREATE TABLE `unit` (
  `unit_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `unit_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`unit_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `unit` */

insert  into `unit`(`unit_id`,`unit_name`) values (1,'Pieces'),(2,'Cases');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `user_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `branch_id` bigint(20) DEFAULT NULL,
  `username` varbinary(30) DEFAULT NULL,
  `password` varbinary(100) DEFAULT NULL,
  `salt` varbinary(100) DEFAULT NULL,
  `user_type` varchar(10) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  `is_logged_in` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`user_id`),
  KEY `branch_id` (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

/*Data for the table `user` */

/*Table structure for table `user_details` */

DROP TABLE IF EXISTS `user_details`;

CREATE TABLE `user_details` (
  `user_id` bigint(20) DEFAULT NULL,
  `user_surname` varchar(30) DEFAULT NULL,
  `user_gname` varchar(30) DEFAULT NULL,
  `user_mi` varchar(10) DEFAULT NULL,
  `user_suffix` varchar(10) DEFAULT NULL,
  KEY `user_id` (`user_id`),
  CONSTRAINT `user_details_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `user_details` */

insert  into `user_details`(`user_id`,`user_surname`,`user_gname`,`user_mi`,`user_suffix`) values (1,'Antonio','Renier','',''),(2,'Tsuki','Ame','',''),(3,'Pedro','Juan','',''),(4,'Doe','John','',''),(6,'Wilson','Wade','D.',''),(7,'Rizal','Jose','P.',''),(8,'Bonifacio','Andres','',''),(9,'Hampaslupa','Agapito','H.',''),(10,'Wayne','Bruce','',''),(11,'Kitty','Hello','',''),(12,'Poppins','Mary','',''),(13,'Stark','Tony','',''),(14,'Boop','Betty','',''),(15,'George','Peppa','','');

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `user_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `branch_id` bigint(20) DEFAULT NULL,
  `username` varbinary(30) DEFAULT NULL,
  `password` varbinary(100) DEFAULT NULL,
  `salt` varbinary(100) DEFAULT NULL,
  `user_type` varchar(10) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  `is_logged_in` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`user_id`),
  KEY `branch_id` (`branch_id`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4;

/*Data for the table `users` */

insert  into `users`(`user_id`,`branch_id`,`username`,`password`,`salt`,`user_type`,`is_active`,`is_logged_in`) values (1,1,'Admin123','6JwtKFYJubYRVT7Q7Ib68211QJ4tuAbCu4sGQK4GmfA=','PNE7+tlSXkvQ0ltJIKmtaoyujhYIy1X1Ubtcx0NdaW8=','Admin',1,1),(2,2,'ren1234','t2EYinLOSpJ6ScK84+0cFpGF+c5o68SxzTuS2Lp9V80=','CTvbvtwkhu+ScSt0f3GIo016Ei6gLxdXdSrq8WYXizc=','Cashier',1,0),(3,3,'JuanP3dro','MUMrxDAgohbv8ZwFWawIhTR9JOSIouweju+YNosvh2k=','hPsALsSE3NyR8f0VWmutOjhWb6sUtvlvRGpWj5yjqVs=','Cashier',0,0),(4,3,'Jhon12345','H22EDWR8j7sRtt8BX9F9Y6egZnmF5gWQ+f60zXl+w98=','QXRw9/c7CvP7DFsGz+Y8bwl4FEaZflMnHy6OECQKq1E=','Manager',1,0),(6,2,'W4d3yyy','XuBFNaaJum59+xW6iX3BaVRvGiswXFtlux5CheZdWRU=','WPTrAcbqEhS/8CQiri87dAojTEyyhTbAbLDR1l0jdcY=','Manager',1,0),(7,6,'P3p3ng','yIsKWPnyNJplOhkOZqOxeQIDz6IFv6hsZDJlUAz4Fp8=','SCeMW51oZ8RBymc+tsFMJOc60FvKrK6esMRaIDKnvw4=','Cashier',1,0),(8,5,'D4k1lang_','EohOYsihvuKvFb04l3r6Dynh16weGfRArQufGlXXPjM=','eGWNVczm4VOGEFeIikdY8R1P8PYPaFgM+miKM/LZVhw=','Manager',1,0),(9,1,'asdf','V/3zOn0QytiCl2Sc3fakpwZYrBkVcvBH/ShvuSA9Cjs=','PNlQSp+KTk74L7iLKUB+A/pSJzU9iE1Tq8fDEZWb/Rw=','Cashier',1,0),(10,6,'BruceBruce','xSYLDkg2nuAXn6XjXYTj3REXVNzbPhhH0FWoGQDGPzE=','DVGmNZHVngvhVCU7UYszg7gyuLz8z7K312U+B4P6F+k=','Manager',1,0),(11,6,'Hello','KiwoMkcltqPg1pHVKPDojLgrxIzHCey4qWfWI+uZRKY=','KHQmZp1oRSGDej3AsFPvGjfC+ZeFfAncigvNW/nZ+Pg=','Cashier',1,0),(12,7,'Mary123','YZSWvBpEW889MqkbVW3bIfVz2pQ6naIQ/2fJOlRWmiw=','nFxqa4GpxJj97hTZPnr4rlbmZ9HSJG974Fi5GUBkE5Y=','Cashier',1,0),(13,7,'Tony123','jw2M2zUr92woOGHyN6YejxiPNpQHkEAibiIxzM4EAxY=','LOhQ2gX/yWuJvG50TEZKBPEgcg3ezYYEuL78YEdP0Gc=','Manager',1,0),(14,8,'Betty123','6Q0ycOmbNN6i47XJjJVZPKkOyo4Yh6A1FOrRx6s6qvY=','NB3z05dtbQ/q31wpSg5rn+5XBPUjekWPVIJKyONf9yg=','Cashier',1,0),(15,8,'Peppa123','it6xmU1tn8UvyJdSM8MBM2m7foZxT6x5fXgVz3oneeg=','iZ/2g94XKH4rn4Zom3qa7WUq/+89nqVNGSkicGfhSDU=','Manager',1,0);

/*Table structure for table `vw_stock_adjust_history` */

DROP TABLE IF EXISTS `vw_stock_adjust_history`;

/*!50001 DROP VIEW IF EXISTS `vw_stock_adjust_history` */;
/*!50001 DROP TABLE IF EXISTS `vw_stock_adjust_history` */;

/*!50001 CREATE TABLE  `vw_stock_adjust_history`(
 `phys_count_id` bigint(20) ,
 `count_date` date ,
 `item_code` varchar(20) ,
 `brand_name` varchar(50) ,
 `item_desc` varchar(50) ,
 `item_add_desc` varchar(50) ,
 `category_name` varchar(50) ,
 `branch_address` varchar(100) ,
 `qty` int(11) ,
 `ref_no` bigint(10) ,
 `period_from` date ,
 `period_to` date 
)*/;

/*Table structure for table `vw_stock_in_history` */

DROP TABLE IF EXISTS `vw_stock_in_history`;

/*!50001 DROP VIEW IF EXISTS `vw_stock_in_history` */;
/*!50001 DROP TABLE IF EXISTS `vw_stock_in_history` */;

/*!50001 CREATE TABLE  `vw_stock_in_history`(
 `stock_in_id` bigint(20) ,
 `ref_no` bigint(10) ,
 `trans_date` date ,
 `branch_address` varchar(100) ,
 `item_code` varchar(20) ,
 `brand_name` varchar(50) ,
 `item_desc` varchar(50) ,
 `item_add_desc` varchar(50) ,
 `category_name` varchar(50) ,
 `unit_name` varchar(50) ,
 `qty` int(11) ,
 `supplier_name` varchar(50) 
)*/;

/*Table structure for table `vw_stock_list` */

DROP TABLE IF EXISTS `vw_stock_list`;

/*!50001 DROP VIEW IF EXISTS `vw_stock_list` */;
/*!50001 DROP TABLE IF EXISTS `vw_stock_list` */;

/*!50001 CREATE TABLE  `vw_stock_list`(
 `item_id` bigint(20) ,
 `branch_address` varchar(100) ,
 `item_code` varchar(20) ,
 `brand_name` varchar(50) ,
 `item_desc` varchar(50) ,
 `item_add_desc` varchar(50) ,
 `category_name` varchar(50) ,
 `unit_name` varchar(50) ,
 `qty` int(11) 
)*/;

/*Table structure for table `vw_stock_out_history` */

DROP TABLE IF EXISTS `vw_stock_out_history`;

/*!50001 DROP VIEW IF EXISTS `vw_stock_out_history` */;
/*!50001 DROP TABLE IF EXISTS `vw_stock_out_history` */;

/*!50001 CREATE TABLE  `vw_stock_out_history`(
 `stock_out_id` bigint(20) ,
 `trans_date` date ,
 `ref_no` bigint(10) ,
 `branch_address` varchar(100) ,
 `item_code` varchar(20) ,
 `brand_name` varchar(50) ,
 `item_desc` varchar(50) ,
 `item_add_desc` varchar(50) ,
 `category_name` varchar(50) ,
 `unit_name` varchar(50) ,
 `qty` int(11) 
)*/;

/*Table structure for table `vw_stock_ret_history` */

DROP TABLE IF EXISTS `vw_stock_ret_history`;

/*!50001 DROP VIEW IF EXISTS `vw_stock_ret_history` */;
/*!50001 DROP TABLE IF EXISTS `vw_stock_ret_history` */;

/*!50001 CREATE TABLE  `vw_stock_ret_history`(
 `stock_ret_id` bigint(20) ,
 `trans_date` date ,
 `ref_no` bigint(10) ,
 `item_code` varchar(20) ,
 `brand_name` varchar(50) ,
 `item_desc` varchar(50) ,
 `item_add_desc` varchar(50) ,
 `category_name` varchar(50) ,
 `unit_name` varchar(50) ,
 `qty` int(11) ,
 `supplier_name` varchar(50) ,
 `branch_address` varchar(100) 
)*/;

/*Table structure for table `vw_stock_trans_history` */

DROP TABLE IF EXISTS `vw_stock_trans_history`;

/*!50001 DROP VIEW IF EXISTS `vw_stock_trans_history` */;
/*!50001 DROP TABLE IF EXISTS `vw_stock_trans_history` */;

/*!50001 CREATE TABLE  `vw_stock_trans_history`(
 `stock_trans_id` bigint(20) ,
 `ref_no` bigint(10) ,
 `trans_date` date ,
 `b_from` varchar(100) ,
 `b_to` varchar(100) ,
 `item_code` varchar(20) ,
 `brand_name` varchar(50) ,
 `item_desc` varchar(50) ,
 `item_add_desc` varchar(50) ,
 `category_name` varchar(50) ,
 `unit_name` varchar(50) ,
 `qty` int(11) ,
 `remarks` varchar(255) 
)*/;

/*View structure for view vw_stock_adjust_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_adjust_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_adjust_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_adjust_history` AS (select `physical_count`.`phys_count_id` AS `phys_count_id`,`physical_count`.`count_date` AS `count_date`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`branch`.`branch_address` AS `branch_address`,`physical_count`.`qty` AS `qty`,`physical_count`.`ref_no` AS `ref_no`,`inventory_period`.`period_from` AS `period_from`,`inventory_period`.`period_to` AS `period_to` from ((((((`inventory` join `physical_count` on((`physical_count`.`inventory_id` = `inventory`.`inventory_id`))) join `inventory_period` on((`inventory_period`.`inv_period_id` = `physical_count`.`inv_period_id`))) join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `branch` on((`branch`.`branch_id` = `inventory`.`branch_id`)))) */;

/*View structure for view vw_stock_in_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_in_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_in_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_in_history` AS (select `stock_in`.`stock_in_id` AS `stock_in_id`,`stock_in`.`ref_no` AS `ref_no`,`stock_in`.`trans_date` AS `trans_date`,`branch`.`branch_address` AS `branch_address`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`stock_in`.`qty` AS `qty`,`supplier`.`supplier_name` AS `supplier_name` from (((((((`inventory` join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `stock_in` on((`stock_in`.`inventory_id` = `inventory`.`inventory_id`))) join `supplier` on((`supplier`.`supplier_id` = `stock_in`.`supplier_id`))) join `branch` on((`branch`.`branch_id` = `stock_in`.`branch_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`)))) */;

/*View structure for view vw_stock_list */

/*!50001 DROP TABLE IF EXISTS `vw_stock_list` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_list` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_list` AS (select `inventory`.`item_id` AS `item_id`,`branch`.`branch_address` AS `branch_address`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`inventory`.`qty` AS `qty` from (((((`inventory` join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `branch` on((`branch`.`branch_id` = `inventory`.`branch_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`)))) */;

/*View structure for view vw_stock_out_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_out_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_out_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_out_history` AS (select `stock_out`.`stock_out_id` AS `stock_out_id`,`stock_out`.`trans_date` AS `trans_date`,`stock_out`.`ref_no` AS `ref_no`,`branch`.`branch_address` AS `branch_address`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`stock_out`.`qty` AS `qty` from ((((((`inventory` join `item` on((`item`.`item_id` = `inventory`.`inventory_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `stock_out` on((`stock_out`.`inventory_id` = `inventory`.`inventory_id`))) join `branch` on((`branch`.`branch_id` = `inventory`.`branch_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`)))) */;

/*View structure for view vw_stock_ret_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_ret_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_ret_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_ret_history` AS (select `stock_return`.`stock_ret_id` AS `stock_ret_id`,`stock_return`.`trans_date` AS `trans_date`,`stock_return`.`ref_no` AS `ref_no`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`stock_return`.`qty` AS `qty`,`supplier`.`supplier_name` AS `supplier_name`,`branch`.`branch_address` AS `branch_address` from (((((((`inventory` join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `stock_return` on((`stock_return`.`inventory_id` = `inventory`.`inventory_id`))) join `supplier` on((`supplier`.`supplier_id` = `stock_return`.`supplier_id`))) join `branch` on((`branch`.`branch_id` = `inventory`.`branch_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`)))) */;

/*View structure for view vw_stock_trans_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_trans_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_trans_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_trans_history` AS (select `stock_transfer`.`stock_trans_id` AS `stock_trans_id`,`stock_transfer`.`ref_no` AS `ref_no`,`stock_transfer`.`trans_date` AS `trans_date`,`branch_from`.`branch_address` AS `b_from`,`branch_to`.`branch_address` AS `b_to`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`stock_transfer`.`qty` AS `qty`,`stock_transfer`.`remarks` AS `remarks` from (((((((`inventory` join `stock_transfer` on((`stock_transfer`.`inventory_id` = `inventory`.`inventory_id`))) join `branch` `branch_from` on((`branch_from`.`branch_id` = `stock_transfer`.`branch_id_from`))) join `branch` `branch_to` on((`branch_to`.`branch_id` = `stock_transfer`.`branch_id_to`))) join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `brand` on((`brand`.`brand_id` = `item`.`item_id`))) join `category` on((`category`.`category_id` = `item`.`item_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`)))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
