/*
SQLyog Enterprise - MySQL GUI v8.18 
MySQL - 5.5.5-10.4.17-MariaDB-log : Database - aje_pos
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`aje_pos` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `aje_pos`;

/*Table structure for table `branch` */

DROP TABLE IF EXISTS `branch`;

CREATE TABLE `branch` (
  `branch_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `branch_address` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `branch` */

insert  into `branch`(`branch_id`,`branch_address`) values (1,'Putik Z.C.'),(2,'Guiwan Z.C.');

/*Table structure for table `brand` */

DROP TABLE IF EXISTS `brand`;

CREATE TABLE `brand` (
  `brand_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `brand_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`brand_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `brand` */

insert  into `brand`(`brand_id`,`brand_name`) values (1,'Coca Cola'),(2,'Fanta');

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cash_payment` */

insert  into `cash_payment`(`cash_pay_id`,`order_id`,`cashier_id`,`trans_date`,`pay_amount`,`receipt`) values (1,2,2,'2022-05-24','100.00','2222222'),(2,3,2,'2022-05-28','100.00','99999'),(3,5,2,'2022-05-31','400.00','33333'),(4,6,2,'2022-05-31','100.00','44444'),(5,7,2,'2022-06-01','100.00','77777'),(6,8,1,'2022-06-09','400.00','1212');

/*Table structure for table `cashier` */

DROP TABLE IF EXISTS `cashier`;

CREATE TABLE `cashier` (
  `cashier_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `user_id` bigint(20) DEFAULT NULL,
  `username` varbinary(30) DEFAULT NULL,
  `password` varbinary(100) DEFAULT NULL,
  `salt` varbinary(100) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  `is_logged_in` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`cashier_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `cashier_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cashier` */

insert  into `cashier`(`cashier_id`,`user_id`,`username`,`password`,`salt`,`is_active`,`is_logged_in`) values (1,2,'Juan123','UD6h5i3l7/3xQt/LVq4kOQkXy/zumMCFReEtkAwvp/U=','d3qW/WeKGsiCUiARyx1lcWk3MWe1q8wEfGONzahDxaU=',1,0),(2,3,'Pedro123','GMrjd8Y6Zj6lSobsEdxHlTXK0QKwsG8lucwO1t/jWhY=','vmdz3trzwmRova0hkwyssiDLWQz3JwZpOhZ/JQ4ZnWg=',1,0);

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
  `end_bal` decimal(15,2) DEFAULT 0.00,
  PRIMARY KEY (`cashier_log_id`),
  KEY `manager_id` (`manager_id`),
  KEY `cashier_id` (`cashier_id`),
  CONSTRAINT `cashier_log_ibfk_2` FOREIGN KEY (`manager_id`) REFERENCES `manager` (`manager_id`),
  CONSTRAINT `cashier_log_ibfk_3` FOREIGN KEY (`cashier_id`) REFERENCES `cashier` (`cashier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cashier_log` */

insert  into `cashier_log`(`cashier_log_id`,`cashier_id`,`manager_id`,`log_date`,`time_from`,`time_to`,`begin_bal`,`end_bal`) values (1,2,1,'2022-05-24','18:57:53','19:02:35','3000.00','3050.00'),(2,2,1,'2022-05-24','19:13:16','19:17:43','3050.00','3180.00'),(3,2,1,'2022-05-24','19:21:55','19:22:02','3180.00','3310.00'),(4,2,1,'2022-05-27','20:07:29','20:18:24','2000.00','2000.00'),(5,2,1,'2022-05-28','18:11:58','18:21:18','4000.00','4090.00'),(6,2,1,'2022-05-28','19:09:04','19:11:06','5000.00','4900.00'),(7,2,1,'2022-05-30','13:43:12',NULL,'4000.00','0.00'),(8,2,1,'2022-05-30','13:48:17',NULL,'4000.00','0.00'),(9,2,1,'2022-05-30','13:49:46',NULL,'4000.00','0.00'),(10,2,1,'2022-05-30','13:51:33',NULL,'4000.00','0.00'),(11,2,1,'2022-05-30','13:55:16',NULL,'4000.00','0.00'),(12,2,1,'2022-05-30','13:58:10',NULL,'4000.00','0.00'),(13,2,1,'2022-05-30','14:16:40',NULL,'4000.00','0.00'),(14,2,1,'2022-05-30','14:21:25',NULL,'4000.00','0.00'),(15,2,1,'2022-05-30','17:22:06',NULL,'4000.00','0.00'),(16,2,1,'2022-05-30','17:26:02',NULL,'4000.00','0.00'),(17,2,1,'2022-05-30','17:31:09','17:31:28','4000.00','4000.00'),(18,2,1,'2022-05-30','17:45:41',NULL,'4000.00','0.00'),(19,2,1,'2022-05-30','21:25:32',NULL,'4000.00','0.00'),(20,2,1,'2022-05-31','11:19:48','11:20:04','4000.00','4000.00'),(21,2,1,'2022-05-31','16:43:32','16:47:16','4000.00','4000.00'),(22,2,1,'2022-05-31','16:59:04',NULL,'4000.00','0.00'),(23,2,1,'2022-05-31','17:03:40',NULL,'4000.00','0.00'),(24,2,1,'2022-05-31','17:11:19',NULL,'4000.00','0.00'),(25,2,1,'2022-05-31','17:15:01','17:15:16','4000.00','4000.00'),(26,2,1,'2022-05-31','17:19:21','17:20:46','4000.00','4000.00'),(27,2,1,'2022-05-31','17:25:13','17:29:07','4000.00','4000.00'),(28,2,1,'2022-05-31','17:39:42','17:43:13','4000.00','4000.00'),(29,2,1,'2022-05-31','19:23:15','19:25:53','4000.00','4150.00'),(30,2,1,'2022-05-31','19:26:23',NULL,'4000.00','0.00'),(31,2,1,'2022-06-01','16:56:24','16:57:47','4000.00','4000.00'),(32,2,1,'2022-06-01','17:05:31','17:06:13','4000.00','4000.00'),(33,2,1,'2022-06-01','18:17:30',NULL,'4000.00','0.00'),(34,1,1,'2022-06-06','18:22:14',NULL,'8000.00','0.00'),(35,1,1,'2022-06-06','18:32:56',NULL,'8000.00','0.00'),(36,1,1,'2022-06-06','18:35:51',NULL,'8000.00','0.00'),(37,1,1,'2022-06-06','18:40:51',NULL,'8000.00','0.00'),(38,1,1,'2022-06-06','18:44:34',NULL,'8000.00','0.00'),(39,1,1,'2022-06-06','18:51:59','19:00:41','8000.00','7985.00'),(40,2,1,'2022-06-06','19:03:02','19:03:56','8000.00','8000.00'),(41,2,1,'2022-06-07','16:35:05','16:38:21','5000.00','5000.00'),(42,1,1,'2022-06-07','17:11:14','17:11:25','5000.00','5000.00'),(43,1,1,'2022-06-07','17:28:39','17:30:07','5000.00','5000.00'),(44,1,1,'2022-06-07','19:25:30','19:28:11','6000.00','6000.00'),(45,1,1,'2022-06-07','19:54:38',NULL,'9000.00','0.00'),(46,1,1,'2022-06-07','20:08:08','20:11:06','4999.99','4999.99'),(47,1,1,'2022-06-08','08:37:59','08:38:27','8000.00','8000.00'),(48,1,1,'2022-06-08','08:47:27',NULL,'8000.00','0.00'),(49,1,1,'2022-06-08','08:49:16','08:49:44','8000.00','8000.00'),(50,1,1,'2022-06-08','08:58:25',NULL,'8000.00','0.00'),(51,1,1,'2022-06-08','09:03:38',NULL,'8000.00','0.00'),(52,1,1,'2022-06-08','17:41:23',NULL,'8000.00','0.00'),(53,1,1,'2022-06-08','17:49:33',NULL,'9000.00','0.00'),(54,1,1,'2022-06-08','18:08:51',NULL,'9000.00','0.00'),(55,1,1,'2022-06-08','18:12:40','18:14:01','9000.00','9000.00'),(56,1,1,'2022-06-08','18:28:37','18:30:16','9000.00','9000.00'),(57,1,1,'2022-06-08','18:54:45',NULL,'9000.00','0.00'),(58,1,1,'2022-06-08','18:57:21','19:06:56','9000.00','9000.00'),(59,1,1,'2022-06-08','20:08:17',NULL,'900.00','0.00'),(60,1,1,'2022-06-08','20:10:23','20:12:00','9000.00','9000.00'),(61,1,1,'2022-06-09','16:17:38',NULL,'9000.00','0.00'),(62,1,1,'2022-06-09','16:20:10',NULL,'9000.00','0.00'),(63,1,1,'2022-06-09','16:22:19',NULL,'9000.00','0.00'),(64,1,1,'2022-06-09','16:29:00',NULL,'9000.00','0.00'),(65,1,1,'2022-06-09','16:38:35',NULL,'9000.00','0.00'),(66,1,1,'2022-06-09','16:41:13',NULL,'9000.00','0.00'),(67,1,1,'2022-06-09','16:44:29',NULL,'9000.00','0.00'),(68,1,1,'2022-06-09','16:49:06',NULL,'9000.00','0.00'),(69,1,1,'2022-06-09','16:53:54',NULL,'9000.00','0.00'),(70,1,1,'2022-06-09','16:57:28',NULL,'9000.00','0.00'),(71,1,1,'2022-06-09','17:00:22',NULL,'9000.00','0.00'),(72,1,1,'2022-06-09','17:04:15',NULL,'9000.00','0.00'),(73,1,1,'2022-06-09','17:19:55','17:24:19','9000.00','9000.00'),(74,1,1,'2022-06-09','17:29:01','17:30:16','9000.00','9000.00'),(75,1,1,'2022-06-09','17:35:53',NULL,'9000.00','0.00'),(76,1,1,'2022-06-09','17:40:53','17:43:04','9000.00','9375.00');

/*Table structure for table `category` */

DROP TABLE IF EXISTS `category`;

CREATE TABLE `category` (
  `category_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `category_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `category` */

insert  into `category`(`category_id`,`category_name`) values (2,'Tire'),(4,'Softdrinks');

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `credit_payment` */

insert  into `credit_payment`(`credit_pay_id`,`order_id`,`cashier_id`,`customer_id`,`trans_date`,`pay_amount`,`invoice`) values (1,1,2,1,'2022-05-24','50.00','11111111'),(2,4,2,2,'2022-05-28','90.00','88888');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `credit_settle` */

/*Table structure for table `customer` */

DROP TABLE IF EXISTS `customer`;

CREATE TABLE `customer` (
  `customer_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `customer_code` varchar(30) DEFAULT NULL,
  `credit_limit` decimal(15,2) DEFAULT 0.00,
  `balance` decimal(15,2) DEFAULT 0.00,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `customer` */

insert  into `customer`(`customer_id`,`customer_code`,`credit_limit`,`balance`) values (1,'cust-0001','10000.00','20.00'),(2,'cust-0002','8000.00','-90.00');

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

insert  into `customer_details`(`customer_id`,`customer_surname`,`customer_gname`,`customer_mi`,`customer_suffix`) values (1,'Strange','Stephen','',''),(2,'Parker','Peter','','');

/*Table structure for table `inventory` */

DROP TABLE IF EXISTS `inventory`;

CREATE TABLE `inventory` (
  `inventory_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `item_id` bigint(20) DEFAULT NULL,
  `branch_id` bigint(20) DEFAULT NULL,
  `qty` int(11) DEFAULT 0,
  PRIMARY KEY (`inventory_id`),
  KEY `item_id` (`item_id`),
  KEY `branch_id` (`branch_id`),
  CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_id`),
  CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `inventory` */

insert  into `inventory`(`inventory_id`,`item_id`,`branch_id`,`qty`) values (1,1,1,16),(2,2,1,14),(3,1,2,2);

/*Table structure for table `inventory_period` */

DROP TABLE IF EXISTS `inventory_period`;

CREATE TABLE `inventory_period` (
  `inv_period_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `period_from` date DEFAULT NULL,
  `period_to` date DEFAULT NULL,
  PRIMARY KEY (`inv_period_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `inventory_period` */

insert  into `inventory_period`(`inv_period_id`,`period_from`,`period_to`) values (1,'2022-05-25','2022-05-24');

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `item` */

insert  into `item`(`item_id`,`item_code`,`item_desc`,`item_add_desc`,`brand_id`,`category_id`,`unit_id`,`item_unit_price`,`item_price_A`,`item_price_B`) values (1,'item-0001','Coke','Original',1,4,1,'13.00','15.00','15.00'),(2,'item-0002','Orange','Original',2,4,2,'35.00','40.00','38.50');

/*Table structure for table `manager` */

DROP TABLE IF EXISTS `manager`;

CREATE TABLE `manager` (
  `manager_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `user_id` bigint(20) DEFAULT NULL,
  `username` varbinary(30) DEFAULT NULL,
  `password` varbinary(100) DEFAULT NULL,
  `salt` varbinary(100) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  `is_logged_in` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`manager_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `manager_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `manager` */

insert  into `manager`(`manager_id`,`user_id`,`username`,`password`,`salt`,`is_active`,`is_logged_in`) values (1,2,'Juan123','T/RpPxvUz9I+Ca2FVL6AFu6mECNHmJ+DuC9bf4cjrA4=','/s63lUK9YOQHC7r6UtFN2RTnp4zb//12dOaTa8VOqFE=',1,0);

/*Table structure for table `misc` */

DROP TABLE IF EXISTS `misc`;

CREATE TABLE `misc` (
  `critical_stock` bigint(20) DEFAULT 0,
  `credit_limit` decimal(12,2) DEFAULT 0.00,
  `misc_id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`misc_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `misc` */

insert  into `misc`(`critical_stock`,`credit_limit`,`misc_id`) values (10,'10000.00',1);

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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

/*Data for the table `order_item_dtls` */

insert  into `order_item_dtls`(`order_item_id`,`order_id`,`inventory_id`,`qty`,`price`,`line_total`) values (1,2,2,2,'40.00','80.00'),(2,3,1,1,'15.00','15.00'),(3,4,2,1,'40.00','40.00'),(4,6,1,2,'15.00','30.00'),(5,6,2,1,'40.00','40.00'),(6,7,1,2,'15.00','30.00'),(7,8,1,5,'15.00','75.00'),(8,8,2,2,'40.00','80.00');

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

/*Data for the table `order_svc_dtls` */

insert  into `order_svc_dtls`(`order_svc_dtls`,`order_id`,`service_id`,`qty`,`price`,`line_total`) values (1,1,2,1,'70.00','70.00'),(2,3,2,1,'70.00','70.00'),(3,4,1,1,'150.00','150.00'),(5,5,1,2,'150.00','300.00'),(6,5,2,1,'70.00','70.00'),(7,7,2,1,'70.00','70.00'),(8,8,2,1,'70.00','70.00'),(9,8,1,1,'150.00','150.00');

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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

/*Data for the table `orders` */

insert  into `orders`(`order_id`,`trans_date`,`gross_amount`,`trans_code`,`branch_id`) values (1,'2022-05-24','70.00',1,1),(2,'2022-05-24','80.00',2,1),(3,'2022-05-28','85.00',1,1),(4,'2022-05-28','190.00',2,1),(5,'2022-05-31','370.00',1,1),(6,'2022-05-31','70.00',2,1),(7,'2022-06-01','100.00',1,1),(8,'2022-06-09','375.00',1,1);

/*Table structure for table `physical_count` */

DROP TABLE IF EXISTS `physical_count`;

CREATE TABLE `physical_count` (
  `phys_count_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `inv_period_id` bigint(20) DEFAULT NULL,
  `inventory_id` bigint(20) DEFAULT NULL,
  `qty` int(11) DEFAULT 0,
  `count_date` date DEFAULT NULL,
  `ref_no` bigint(10) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`phys_count_id`),
  KEY `inventory_id` (`inventory_id`),
  KEY `inv_period_id` (`inv_period_id`),
  CONSTRAINT `physical_count_ibfk_4` FOREIGN KEY (`inv_period_id`) REFERENCES `inventory_period` (`inv_period_id`),
  CONSTRAINT `physical_count_ibfk_5` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`inventory_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `physical_count` */

insert  into `physical_count`(`phys_count_id`,`inv_period_id`,`inventory_id`,`qty`,`count_date`,`ref_no`,`remarks`) values (1,1,1,10,'2022-05-24',1,'this is the real life this is a fantasy stuck in the last life no escape from reality');

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `refund` */

insert  into `refund`(`refund_id`,`order_id`,`cashier_id`,`manager_id`,`amount`,`trans_date`,`remarks`) values (1,3,2,1,'85.00','2022-05-28','refund cash payment'),(2,4,2,1,'190.00','2022-05-28','test credit refund'),(3,5,2,1,'220.00','2022-05-31','hecker'),(4,6,2,1,'55.00','2022-05-31','beluga'),(5,7,1,1,'15.00','2022-06-06','test new refund checking');

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `refund_item_dtls` */

insert  into `refund_item_dtls`(`refund_item_id`,`refund_id`,`inventory_id`,`qty`,`price`,`sub_total`) values (1,1,1,1,'15.00','15.00'),(2,2,2,1,'40.00','40.00'),(3,4,1,1,'15.00','15.00'),(4,4,2,1,'40.00','40.00'),(5,5,1,1,'15.00','15.00');

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `refund_svc_dtls` */

insert  into `refund_svc_dtls`(`refund_svc_id`,`refund_id`,`service_id`,`qty`,`price`,`sub_total`) values (1,1,2,1,'70.00','70.00'),(2,2,1,1,'150.00','150.00'),(4,3,1,1,'150.00','150.00'),(5,3,2,1,'70.00','70.00');

/*Table structure for table `service` */

DROP TABLE IF EXISTS `service`;

CREATE TABLE `service` (
  `service_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `service_code` varchar(20) DEFAULT NULL,
  `service_desc` varchar(50) DEFAULT NULL,
  `service_fee_A` decimal(15,2) DEFAULT NULL,
  `service_fee_B` decimal(15,2) DEFAULT NULL,
  PRIMARY KEY (`service_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `service` */

insert  into `service`(`service_id`,`service_code`,`service_desc`,`service_fee_A`,`service_fee_B`) values (1,'srvc-0001','Tire Change','150.00','140.00'),(2,'srvc-0002','Oil Change','70.00','50.00');

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_in` */

insert  into `stock_in`(`stock_in_id`,`inventory_id`,`branch_id`,`supplier_id`,`ref_no`,`qty`,`trans_date`,`remarks`) values (1,1,1,1,1,10,'2022-05-24','initial stock in'),(2,2,1,1,1,10,'2022-05-24','initial stock in'),(3,1,1,2,2,10,'2022-05-24','lorem ipsum dolor sit amet mi amio ga duka'),(4,2,1,2,2,10,'2022-05-24','lorem ipsum dolor sit amet mi amio ga duka'),(5,1,1,2,3,2,'2022-05-23','');

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_out` */

insert  into `stock_out`(`stock_out_id`,`inventory_id`,`branch_id`,`ref_no`,`qty`,`trans_date`,`remarks`) values (1,1,1,1,2,'2022-05-24','I have a question to the world not an answer to be heard');

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_return` */

insert  into `stock_return`(`stock_ret_id`,`inventory_id`,`branch_id`,`supplier_id`,`ref_no`,`qty`,`trans_date`,`remarks`) values (1,2,1,2,1,2,'2022-05-24','One punch man is great');

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_transfer` */

insert  into `stock_transfer`(`stock_trans_id`,`inventory_id`,`branch_id_from`,`branch_id_to`,`ref_no`,`qty`,`trans_date`,`remarks`) values (1,1,1,2,1,2,'2022-05-24','langit lupa impyerno im-im impyerno');

/*Table structure for table `supplier` */

DROP TABLE IF EXISTS `supplier`;

CREATE TABLE `supplier` (
  `supplier_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(50) DEFAULT NULL,
  `supplier_address` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `supplier` */

insert  into `supplier`(`supplier_id`,`supplier_name`,`supplier_address`) values (1,'Michellin','U.S.A'),(2,'GoodYear','Philippines');

/*Table structure for table `unit` */

DROP TABLE IF EXISTS `unit`;

CREATE TABLE `unit` (
  `unit_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `unit_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`unit_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `unit` */

insert  into `unit`(`unit_id`,`unit_name`) values (1,'12 oz.'),(2,'1 Liter'),(3,'Piece(s)');

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

insert  into `user_details`(`user_id`,`user_surname`,`user_gname`,`user_mi`,`user_suffix`) values (1,'Antonio','Ren','',''),(2,'Tamad','Juan','',''),(3,'Hampaslupa','Pedro','','');

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
  `is_logged_in` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`user_id`),
  KEY `branch_id` (`branch_id`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `users` */

insert  into `users`(`user_id`,`branch_id`,`username`,`password`,`salt`,`user_type`,`is_active`,`is_logged_in`) values (1,1,'admin','N24WUCv2Sz17s/UOHVG7KZlSIlACGcAVlo/euwlxz4g=','SxqrSevNPv/CVkjWfsoAGkuy3uA74UY0TKskZb9cVRE=','Admin',1,0),(2,1,'Juan','5sFm6B5fgT5WrlL1ID8XkJ+LgZWPH5g9vrjJz0c82Vc=','NBGrMpJmVwO3+abAGk0AIm4blIfXgP/dog5biNWtqOE=','Manager',1,0),(3,1,'Pedro','GMviqJ5L76BtAjlYqm3PRhyfYXVb7O4MBKXgiIpUglw=','xdjfiyRcTvfRH7+2CR7HOgdWs0ank/T7usg8Z+l3nrk=','Cashier',1,0);

/*Table structure for table `void` */

DROP TABLE IF EXISTS `void`;

CREATE TABLE `void` (
  `void_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `order_id` bigint(20) DEFAULT NULL,
  `cashier_id` bigint(20) DEFAULT NULL,
  `manager_id` bigint(20) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`void_id`),
  KEY `order_id` (`order_id`),
  KEY `cashier_id` (`cashier_id`),
  KEY `manager_id` (`manager_id`),
  CONSTRAINT `cashier_id` FOREIGN KEY (`cashier_id`) REFERENCES `cashier` (`cashier_id`),
  CONSTRAINT `manager_id` FOREIGN KEY (`manager_id`) REFERENCES `manager` (`manager_id`),
  CONSTRAINT `order_id` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

/*Data for the table `void` */

insert  into `void`(`void_id`,`order_id`,`cashier_id`,`manager_id`,`trans_date`,`remarks`) values (15,2,1,1,'2022-06-09','test on item'),(16,1,1,1,'2022-06-09','asdfa'),(17,8,1,1,'2022-06-09','hekhek');

/*Table structure for table `vw_all_sales` */

DROP TABLE IF EXISTS `vw_all_sales`;

/*!50001 DROP VIEW IF EXISTS `vw_all_sales` */;
/*!50001 DROP TABLE IF EXISTS `vw_all_sales` */;

/*!50001 CREATE TABLE  `vw_all_sales`(
 `DateInputed` date ,
 `transDate` date ,
 `Customers` varchar(72) ,
 `invoice` varchar(50) ,
 `Description` varchar(156) ,
 `Category` varchar(50) ,
 `Unit` varchar(50) ,
 `price` decimal(15,2) ,
 `qty` int(11) ,
 `line_total` decimal(15,2) ,
 `Cashiers` varchar(72) ,
 `branch_id` bigint(20) 
)*/;

/*Table structure for table `vw_cashier_log` */

DROP TABLE IF EXISTS `vw_cashier_log`;

/*!50001 DROP VIEW IF EXISTS `vw_cashier_log` */;
/*!50001 DROP TABLE IF EXISTS `vw_cashier_log` */;

/*!50001 CREATE TABLE  `vw_cashier_log`(
 `branch_id` bigint(20) ,
 `log_date` date ,
 `Cashiers` varchar(61) ,
 `Managers` varchar(61) ,
 `time_from` time ,
 `time_to` time ,
 `begin_bal` decimal(15,2) ,
 `end_bal` decimal(15,2) 
)*/;

/*Table structure for table `vw_cash_in` */

DROP TABLE IF EXISTS `vw_cash_in`;

/*!50001 DROP VIEW IF EXISTS `vw_cash_in` */;
/*!50001 DROP TABLE IF EXISTS `vw_cash_in` */;

/*!50001 CREATE TABLE  `vw_cash_in`(
 `branch_id` bigint(20) ,
 `trans_date` date ,
 `Cashiers` varchar(61) ,
 `Managers` varchar(61) ,
 `amount` decimal(15,2) ,
 `remarks` varchar(255) 
)*/;

/*Table structure for table `vw_cash_out` */

DROP TABLE IF EXISTS `vw_cash_out`;

/*!50001 DROP VIEW IF EXISTS `vw_cash_out` */;
/*!50001 DROP TABLE IF EXISTS `vw_cash_out` */;

/*!50001 CREATE TABLE  `vw_cash_out`(
 `branch_id` bigint(20) ,
 `trans_date` date ,
 `Cashiers` varchar(61) ,
 `Managers` varchar(61) ,
 `amount` decimal(15,2) ,
 `remarks` varchar(255) 
)*/;

/*Table structure for table `vw_cash_sales` */

DROP TABLE IF EXISTS `vw_cash_sales`;

/*!50001 DROP VIEW IF EXISTS `vw_cash_sales` */;
/*!50001 DROP TABLE IF EXISTS `vw_cash_sales` */;

/*!50001 CREATE TABLE  `vw_cash_sales`(
 `DateInputed` date ,
 `transDate` date ,
 `receipt` varchar(50) ,
 `Description` varchar(156) ,
 `Category` varchar(50) ,
 `Unit` varchar(50) ,
 `price` decimal(15,2) ,
 `qty` int(11) ,
 `line_total` decimal(15,2) ,
 `Cashiers` varchar(72) ,
 `branch_id` bigint(20) 
)*/;

/*Table structure for table `vw_credit_sales` */

DROP TABLE IF EXISTS `vw_credit_sales`;

/*!50001 DROP VIEW IF EXISTS `vw_credit_sales` */;
/*!50001 DROP TABLE IF EXISTS `vw_credit_sales` */;

/*!50001 CREATE TABLE  `vw_credit_sales`(
 `DateInputed` date ,
 `transDate` date ,
 `Customers` varchar(72) ,
 `invoice` varchar(50) ,
 `DESCRIPTION` varchar(156) ,
 `Category` varchar(50) ,
 `Unit` varchar(50) ,
 `price` decimal(15,2) ,
 `qty` int(11) ,
 `line_total` decimal(15,2) ,
 `pay_amount` decimal(15,2) ,
 `Cashiers` varchar(72) ,
 `branch_id` bigint(20) 
)*/;

/*Table structure for table `vw_customer_balance` */

DROP TABLE IF EXISTS `vw_customer_balance`;

/*!50001 DROP VIEW IF EXISTS `vw_customer_balance` */;
/*!50001 DROP TABLE IF EXISTS `vw_customer_balance` */;

/*!50001 CREATE TABLE  `vw_customer_balance`(
 `Customers` varchar(61) ,
 `credit_limit` decimal(15,2) ,
 `balance` decimal(15,2) 
)*/;

/*Table structure for table `vw_customer_payments` */

DROP TABLE IF EXISTS `vw_customer_payments`;

/*!50001 DROP VIEW IF EXISTS `vw_customer_payments` */;
/*!50001 DROP TABLE IF EXISTS `vw_customer_payments` */;

/*!50001 CREATE TABLE  `vw_customer_payments`(
 `trans_date` date ,
 `receipt` bigint(10) ,
 `Customers` varchar(61) ,
 `pay_amount` decimal(15,2) ,
 `Cashiers` varchar(61) ,
 `Managers` varchar(61) 
)*/;

/*Table structure for table `vw_customer_transactions` */

DROP TABLE IF EXISTS `vw_customer_transactions`;

/*!50001 DROP VIEW IF EXISTS `vw_customer_transactions` */;
/*!50001 DROP TABLE IF EXISTS `vw_customer_transactions` */;

/*!50001 CREATE TABLE  `vw_customer_transactions`(
 `Customers` varchar(72) ,
 `customer_id` bigint(20) ,
 `trans_date` date ,
 `pay_amount` decimal(15,2) ,
 `invoice` varchar(50) ,
 `DESCRIPTION` varchar(156) ,
 `Category` varchar(50) ,
 `Unit` varchar(50) ,
 `price` decimal(15,2) ,
 `qty` int(11) ,
 `line_total` decimal(15,2) ,
 `Cashiers` varchar(72) ,
 `branch_id` bigint(20) 
)*/;

/*Table structure for table `vw_refund` */

DROP TABLE IF EXISTS `vw_refund`;

/*!50001 DROP VIEW IF EXISTS `vw_refund` */;
/*!50001 DROP TABLE IF EXISTS `vw_refund` */;

/*!50001 CREATE TABLE  `vw_refund`(
 `trans_date` date ,
 `Description` varchar(156) ,
 `Category` varchar(50) ,
 `Unit` varchar(50) ,
 `price` decimal(15,2) ,
 `qty` int(11) ,
 `sub_total` decimal(15,2) ,
 `Cashiers` varchar(61) ,
 `Managers` varchar(61) ,
 `remarks` varchar(255) ,
 `branch_id` bigint(20) 
)*/;

/*Table structure for table `vw_refund_cash` */

DROP TABLE IF EXISTS `vw_refund_cash`;

/*!50001 DROP VIEW IF EXISTS `vw_refund_cash` */;
/*!50001 DROP TABLE IF EXISTS `vw_refund_cash` */;

/*!50001 CREATE TABLE  `vw_refund_cash`(
 `trans_date` date ,
 `receipt` varchar(50) ,
 `Description` varchar(156) ,
 `Category` varchar(50) ,
 `Unit` varchar(50) ,
 `qty` int(11) ,
 `price` decimal(15,2) ,
 `sub_total` decimal(15,2) ,
 `Cashiers` varchar(61) ,
 `Managers` varchar(61) ,
 `remarks` varchar(255) ,
 `branch_id` bigint(20) 
)*/;

/*Table structure for table `vw_refund_credit` */

DROP TABLE IF EXISTS `vw_refund_credit`;

/*!50001 DROP VIEW IF EXISTS `vw_refund_credit` */;
/*!50001 DROP TABLE IF EXISTS `vw_refund_credit` */;

/*!50001 CREATE TABLE  `vw_refund_credit`(
 `trans_date` date ,
 `invoice` varchar(50) ,
 `Description` varchar(156) ,
 `Category` varchar(50) ,
 `Unit` varchar(50) ,
 `qty` int(11) ,
 `price` decimal(15,2) ,
 `sub_total` decimal(15,2) ,
 `Cashiers` varchar(61) ,
 `Managers` varchar(61) ,
 `remarks` varchar(255) ,
 `branch_id` bigint(20) 
)*/;

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
 `unit_name` varchar(50) ,
 `branch_address` varchar(100) ,
 `qty` int(11) ,
 `ref_no` bigint(10) ,
 `period_from` date ,
 `period_to` date ,
 `remarks` varchar(255) 
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
 `supplier_name` varchar(50) ,
 `remarks` varchar(255) 
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
 `qty` int(11) ,
 `remarks` varchar(255) 
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
 `branch_address` varchar(100) ,
 `remarks` varchar(255) 
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

/*View structure for view vw_all_sales */

/*!50001 DROP TABLE IF EXISTS `vw_all_sales` */;
/*!50001 DROP VIEW IF EXISTS `vw_all_sales` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_all_sales` AS (select `orders`.`trans_date` AS `DateInputed`,`credit_payment`.`trans_date` AS `transDate`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`credit_payment`.`invoice` AS `invoice`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from ((((((((((`orders` join `order_item_dtls` on(`order_item_dtls`.`order_id` = `orders`.`order_id`)) join `inventory` on(`inventory`.`inventory_id` = `order_item_dtls`.`inventory_id`)) join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `credit_payment` on(`credit_payment`.`order_id` = `orders`.`order_id`)) join `cashier` on(`cashier`.`cashier_id` = `credit_payment`.`cashier_id`)) join `user_details` on(`user_details`.`user_id` = `cashier`.`user_id`)) join `customer_details` on(`customer_details`.`customer_id` = `credit_payment`.`customer_id`))) union (select `orders`.`trans_date` AS `DateInputed`,`credit_payment`.`trans_date` AS `transDate`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`credit_payment`.`invoice` AS `invoice`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from ((((((`orders` join `order_svc_dtls` on(`order_svc_dtls`.`order_id` = `orders`.`order_id`)) join `service` on(`service`.`service_id` = `order_svc_dtls`.`service_id`)) join `credit_payment` on(`credit_payment`.`order_id` = `orders`.`order_id`)) join `cashier` on(`cashier`.`cashier_id` = `credit_payment`.`cashier_id`)) join `user_details` on(`user_details`.`user_id` = `cashier`.`user_id`)) join `customer_details` on(`customer_details`.`customer_id` = `credit_payment`.`customer_id`))) union (select `orders`.`trans_date` AS `DateInputed`,`cash_payment`.`trans_date` AS `transDate`,'' AS `Customers`,`cash_payment`.`receipt` AS `receipt`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((((((`orders` join `order_item_dtls` on(`orders`.`order_id` = `order_item_dtls`.`order_id`)) join `inventory` on(`order_item_dtls`.`inventory_id` = `inventory`.`inventory_id`)) join `item` on(`inventory`.`item_id` = `item`.`item_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `brand` on(`item`.`brand_id` = `brand`.`brand_id`)) join `cash_payment` on(`orders`.`order_id` = `cash_payment`.`order_id`)) join `cashier` on(`cash_payment`.`cashier_id` = `cashier`.`cashier_id`)) join `user_details` on(`cashier`.`user_id` = `user_details`.`user_id`))) union (select `orders`.`trans_date` AS `DateInputed`,`cash_payment`.`trans_date` AS `transDate`,'' AS `Customers`,`cash_payment`.`receipt` AS `receipt`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((`orders` join `order_svc_dtls` on(`order_svc_dtls`.`order_id` = `orders`.`order_id`)) join `service` on(`service`.`service_id` = `order_svc_dtls`.`service_id`)) join `cash_payment` on(`orders`.`order_id` = `cash_payment`.`order_id`)) join `cashier` on(`cash_payment`.`cashier_id` = `cashier`.`cashier_id`)) join `user_details` on(`cashier`.`user_id` = `user_details`.`user_id`))) */;

/*View structure for view vw_cashier_log */

/*!50001 DROP TABLE IF EXISTS `vw_cashier_log` */;
/*!50001 DROP VIEW IF EXISTS `vw_cashier_log` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cashier_log` AS select `users`.`branch_id` AS `branch_id`,`cashier_log`.`log_date` AS `log_date`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`cashier_log`.`time_from` AS `time_from`,`cashier_log`.`time_to` AS `time_to`,`cashier_log`.`begin_bal` AS `begin_bal`,`cashier_log`.`end_bal` AS `end_bal` from (((((`cashier_log` join `cashier` on(`cashier`.`cashier_id` = `cashier_log`.`cashier_id`)) join `manager` on(`manager`.`manager_id` = `cashier_log`.`manager_id`)) join `users` on(`users`.`user_id` = `cashier`.`user_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) order by `cashier_log`.`log_date`,`cashier_log`.`cashier_id` */;

/*View structure for view vw_cash_in */

/*!50001 DROP TABLE IF EXISTS `vw_cash_in` */;
/*!50001 DROP VIEW IF EXISTS `vw_cash_in` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cash_in` AS select `users`.`branch_id` AS `branch_id`,`cash_in`.`trans_date` AS `trans_date`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`cash_in`.`amount` AS `amount`,`cash_in`.`remarks` AS `remarks` from ((((((`cash_in` join `cashier` on(`cashier`.`cashier_id` = `cash_in`.`cashier_id`)) join `manager` on(`manager`.`manager_id` = `cash_in`.`manager_id`)) join `users` on(`users`.`user_id` = `cashier`.`user_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `branch` on(`branch`.`branch_id` = `users`.`branch_id`)) */;

/*View structure for view vw_cash_out */

/*!50001 DROP TABLE IF EXISTS `vw_cash_out` */;
/*!50001 DROP VIEW IF EXISTS `vw_cash_out` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cash_out` AS select `users`.`branch_id` AS `branch_id`,`cash_out`.`trans_date` AS `trans_date`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`cash_out`.`amount` AS `amount`,`cash_out`.`remarks` AS `remarks` from ((((((`cash_out` join `cashier` on(`cashier`.`cashier_id` = `cash_out`.`cashier_id`)) join `manager` on(`manager`.`manager_id` = `cash_out`.`manager_id`)) join `users` on(`users`.`user_id` = `cashier`.`user_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `branch` on(`branch`.`branch_id` = `users`.`branch_id`)) */;

/*View structure for view vw_cash_sales */

/*!50001 DROP TABLE IF EXISTS `vw_cash_sales` */;
/*!50001 DROP VIEW IF EXISTS `vw_cash_sales` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cash_sales` AS (select `orders`.`trans_date` AS `DateInputed`,`cash_payment`.`trans_date` AS `transDate`,`cash_payment`.`receipt` AS `receipt`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((((((`orders` join `order_item_dtls` on(`orders`.`order_id` = `order_item_dtls`.`order_id`)) join `inventory` on(`order_item_dtls`.`inventory_id` = `inventory`.`inventory_id`)) join `item` on(`inventory`.`item_id` = `item`.`item_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `brand` on(`item`.`brand_id` = `brand`.`brand_id`)) join `cash_payment` on(`orders`.`order_id` = `cash_payment`.`order_id`)) join `cashier` on(`cash_payment`.`cashier_id` = `cashier`.`cashier_id`)) join `user_details` on(`cashier`.`user_id` = `user_details`.`user_id`))) union (select `orders`.`trans_date` AS `DateInputed`,`cash_payment`.`trans_date` AS `transDate`,`cash_payment`.`receipt` AS `receipt`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((`orders` join `order_svc_dtls` on(`order_svc_dtls`.`order_id` = `orders`.`order_id`)) join `service` on(`service`.`service_id` = `order_svc_dtls`.`service_id`)) join `cash_payment` on(`orders`.`order_id` = `cash_payment`.`order_id`)) join `cashier` on(`cash_payment`.`cashier_id` = `cashier`.`cashier_id`)) join `user_details` on(`cashier`.`user_id` = `user_details`.`user_id`))) order by `transDate`,`receipt` */;

/*View structure for view vw_credit_sales */

/*!50001 DROP TABLE IF EXISTS `vw_credit_sales` */;
/*!50001 DROP VIEW IF EXISTS `vw_credit_sales` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_credit_sales` AS (select `orders`.`trans_date` AS `DateInputed`,`credit_payment`.`trans_date` AS `transDate`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`credit_payment`.`invoice` AS `invoice`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `DESCRIPTION`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,`credit_payment`.`pay_amount` AS `pay_amount`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from ((((((((((`orders` join `order_item_dtls` on(`order_item_dtls`.`order_id` = `orders`.`order_id`)) join `inventory` on(`inventory`.`inventory_id` = `order_item_dtls`.`inventory_id`)) join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `credit_payment` on(`credit_payment`.`order_id` = `orders`.`order_id`)) join `cashier` on(`cashier`.`cashier_id` = `credit_payment`.`cashier_id`)) join `user_details` on(`user_details`.`user_id` = `cashier`.`user_id`)) join `customer_details` on(`customer_details`.`customer_id` = `credit_payment`.`customer_id`))) union (select `orders`.`trans_date` AS `DateInputed`,`credit_payment`.`trans_date` AS `transDate`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`credit_payment`.`invoice` AS `invoice`,`service`.`service_desc` AS `DESCRIPTION`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,`credit_payment`.`pay_amount` AS `pay_amount`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from ((((((`orders` join `order_svc_dtls` on(`order_svc_dtls`.`order_id` = `orders`.`order_id`)) join `service` on(`service`.`service_id` = `order_svc_dtls`.`service_id`)) join `credit_payment` on(`credit_payment`.`order_id` = `orders`.`order_id`)) join `cashier` on(`cashier`.`cashier_id` = `credit_payment`.`cashier_id`)) join `user_details` on(`user_details`.`user_id` = `cashier`.`user_id`)) join `customer_details` on(`customer_details`.`customer_id` = `credit_payment`.`customer_id`))) */;

/*View structure for view vw_customer_balance */

/*!50001 DROP TABLE IF EXISTS `vw_customer_balance` */;
/*!50001 DROP VIEW IF EXISTS `vw_customer_balance` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_customer_balance` AS select concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`) AS `Customers`,`customer`.`credit_limit` AS `credit_limit`,`customer`.`balance` AS `balance` from (`customer` join `customer_details` on(`customer`.`customer_id` = `customer_details`.`customer_id`)) */;

/*View structure for view vw_customer_payments */

/*!50001 DROP TABLE IF EXISTS `vw_customer_payments` */;
/*!50001 DROP VIEW IF EXISTS `vw_customer_payments` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_customer_payments` AS select `credit_settle`.`trans_date` AS `trans_date`,`credit_settle`.`receipt` AS `receipt`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`) AS `Customers`,`credit_settle`.`pay_amount` AS `pay_amount`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers` from (((((`credit_settle` join `manager` on(`manager`.`manager_id` = `credit_settle`.`manager_id`)) join `cashier` on(`cashier`.`cashier_id` = `credit_settle`.`cashier_id`)) join `customer_details` on(`customer_details`.`customer_id` = `credit_settle`.`customer_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) order by `credit_settle`.`trans_date`,`credit_settle`.`receipt` */;

/*View structure for view vw_customer_transactions */

/*!50001 DROP TABLE IF EXISTS `vw_customer_transactions` */;
/*!50001 DROP VIEW IF EXISTS `vw_customer_transactions` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_customer_transactions` AS (select concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`customer`.`customer_id` AS `customer_id`,`credit_payment`.`trans_date` AS `trans_date`,`credit_payment`.`pay_amount` AS `pay_amount`,`credit_payment`.`invoice` AS `invoice`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `DESCRIPTION`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((((((((`orders` join `credit_payment` on(`credit_payment`.`order_id` = `orders`.`order_id`)) join `order_item_dtls` on(`order_item_dtls`.`order_id` = `orders`.`order_id`)) join `inventory` on(`inventory`.`inventory_id` = `order_item_dtls`.`inventory_id`)) join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`)) join `cashier` on(`credit_payment`.`cashier_id` = `cashier`.`cashier_id`)) join `user_details` on(`user_details`.`user_id` = `cashier`.`user_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `customer` on(`customer`.`customer_id` = `credit_payment`.`customer_id`)) join `customer_details` on(`customer_details`.`customer_id` = `credit_payment`.`customer_id`))) union (select concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`customer`.`customer_id` AS `customer_id`,`credit_payment`.`trans_date` AS `trans_date`,`credit_payment`.`pay_amount` AS `pay_amount`,`credit_payment`.`invoice` AS `invoice`,`service`.`service_desc` AS `DESCRIPTION`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((((`orders` join `credit_payment` on(`credit_payment`.`order_id` = `orders`.`order_id`)) join `order_svc_dtls` on(`order_svc_dtls`.`order_id` = `orders`.`order_id`)) join `service` on(`service`.`service_id` = `order_svc_dtls`.`service_id`)) join `cashier` on(`credit_payment`.`cashier_id` = `cashier`.`cashier_id`)) join `user_details` on(`user_details`.`user_id` = `cashier`.`user_id`)) join `customer` on(`customer`.`customer_id` = `credit_payment`.`customer_id`)) join `customer_details` on(`customer_details`.`customer_id` = `credit_payment`.`customer_id`))) order by `trans_date`,`invoice` */;

/*View structure for view vw_refund */

/*!50001 DROP TABLE IF EXISTS `vw_refund` */;
/*!50001 DROP VIEW IF EXISTS `vw_refund` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_refund` AS (select `refund`.`trans_date` AS `trans_date`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`refund_item_dtls`.`price` AS `price`,`refund_item_dtls`.`qty` AS `qty`,`refund_item_dtls`.`sub_total` AS `sub_total`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`refund`.`remarks` AS `remarks`,`orders`.`branch_id` AS `branch_id` from (((((((((((`refund` join `refund_item_dtls` on(`refund_item_dtls`.`refund_id` = `refund`.`refund_id`)) join `inventory` on(`inventory`.`inventory_id` = `refund_item_dtls`.`inventory_id`)) join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `cashier` on(`cashier`.`cashier_id` = `refund`.`cashier_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `manager` on(`manager`.`manager_id` = `refund`.`manager_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) join `orders` on(`orders`.`order_id` = `refund`.`order_id`))) union (select `refund`.`trans_date` AS `trans_date`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`refund_svc_dtls`.`price` AS `price`,`refund_svc_dtls`.`qty` AS `qty`,`refund_svc_dtls`.`sub_total` AS `sub_total`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`refund`.`remarks` AS `remarks`,`orders`.`branch_id` AS `branch_id` from (((((((`refund` join `refund_svc_dtls` on(`refund_svc_dtls`.`refund_id` = `refund`.`refund_id`)) join `service` on(`service`.`service_id` = `refund_svc_dtls`.`service_id`)) join `cashier` on(`cashier`.`cashier_id` = `refund`.`cashier_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `manager` on(`manager`.`manager_id` = `refund`.`manager_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) join `orders` on(`orders`.`order_id` = `refund`.`order_id`))) */;

/*View structure for view vw_refund_cash */

/*!50001 DROP TABLE IF EXISTS `vw_refund_cash` */;
/*!50001 DROP VIEW IF EXISTS `vw_refund_cash` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_refund_cash` AS select `refund`.`trans_date` AS `trans_date`,`cash_payment`.`receipt` AS `receipt`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`refund_item_dtls`.`qty` AS `qty`,`refund_item_dtls`.`price` AS `price`,`refund_item_dtls`.`sub_total` AS `sub_total`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`refund`.`remarks` AS `remarks`,`inventory`.`branch_id` AS `branch_id` from ((((((((((((`refund` join `orders` on(`orders`.`order_id` = `refund`.`order_id`)) join `refund_item_dtls` on(`refund_item_dtls`.`refund_id` = `refund`.`refund_id`)) join `cash_payment` on(`cash_payment`.`order_id` = `orders`.`order_id`)) join `inventory` on(`inventory`.`inventory_id` = `refund_item_dtls`.`inventory_id`)) join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`)) join `cashier` on(`cashier`.`cashier_id` = `refund`.`cashier_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `manager` on(`manager`.`manager_id` = `refund`.`manager_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) union all select `refund`.`trans_date` AS `trans_date`,`cash_payment`.`receipt` AS `receipt`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`refund_svc_dtls`.`qty` AS `qty`,`refund_svc_dtls`.`price` AS `price`,`refund_svc_dtls`.`sub_total` AS `sub_total`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`refund`.`remarks` AS `remarks`,`orders`.`branch_id` AS `branch_id` from ((((((((`refund` join `orders` on(`refund`.`order_id` = `orders`.`order_id`)) join `refund_svc_dtls` on(`refund_svc_dtls`.`refund_id` = `refund`.`refund_id`)) join `cash_payment` on(`cash_payment`.`order_id` = `orders`.`order_id`)) join `service` on(`service`.`service_id` = `refund_svc_dtls`.`service_id`)) join `cashier` on(`cashier`.`cashier_id` = `refund`.`cashier_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `manager` on(`manager`.`manager_id` = `refund`.`manager_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) */;

/*View structure for view vw_refund_credit */

/*!50001 DROP TABLE IF EXISTS `vw_refund_credit` */;
/*!50001 DROP VIEW IF EXISTS `vw_refund_credit` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_refund_credit` AS select `refund`.`trans_date` AS `trans_date`,`credit_payment`.`invoice` AS `invoice`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`refund_item_dtls`.`qty` AS `qty`,`refund_item_dtls`.`price` AS `price`,`refund_item_dtls`.`sub_total` AS `sub_total`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`refund`.`remarks` AS `remarks`,`inventory`.`branch_id` AS `branch_id` from ((((((((((((`refund` join `orders` on(`orders`.`order_id` = `refund`.`order_id`)) join `refund_item_dtls` on(`refund_item_dtls`.`refund_id` = `refund`.`refund_id`)) join `credit_payment` on(`credit_payment`.`order_id` = `orders`.`order_id`)) join `inventory` on(`inventory`.`inventory_id` = `refund_item_dtls`.`inventory_id`)) join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`)) join `cashier` on(`cashier`.`cashier_id` = `refund`.`cashier_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `manager` on(`manager`.`manager_id` = `refund`.`manager_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) union all select `refund`.`trans_date` AS `trans_date`,`credit_payment`.`invoice` AS `invoice`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`refund_svc_dtls`.`qty` AS `qty`,`refund_svc_dtls`.`price` AS `price`,`refund_svc_dtls`.`sub_total` AS `sub_total`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`refund`.`remarks` AS `remarks`,`orders`.`branch_id` AS `branch_id` from ((((((((`refund` join `orders` on(`refund`.`order_id` = `orders`.`order_id`)) join `refund_svc_dtls` on(`refund_svc_dtls`.`refund_id` = `refund`.`refund_id`)) join `credit_payment` on(`credit_payment`.`order_id` = `orders`.`order_id`)) join `service` on(`service`.`service_id` = `refund_svc_dtls`.`service_id`)) join `cashier` on(`cashier`.`cashier_id` = `refund`.`cashier_id`)) join `user_details` `c` on(`c`.`user_id` = `cashier`.`user_id`)) join `manager` on(`manager`.`manager_id` = `refund`.`manager_id`)) join `user_details` `m` on(`m`.`user_id` = `manager`.`user_id`)) */;

/*View structure for view vw_stock_adjust_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_adjust_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_adjust_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_adjust_history` AS (select `physical_count`.`phys_count_id` AS `phys_count_id`,`physical_count`.`count_date` AS `count_date`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`branch`.`branch_address` AS `branch_address`,`physical_count`.`qty` AS `qty`,`physical_count`.`ref_no` AS `ref_no`,`inventory_period`.`period_from` AS `period_from`,`inventory_period`.`period_to` AS `period_to`,`physical_count`.`remarks` AS `remarks` from (((((((`inventory` join `physical_count` on(`physical_count`.`inventory_id` = `inventory`.`inventory_id`)) join `inventory_period` on(`inventory_period`.`inv_period_id` = `physical_count`.`inv_period_id`)) join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`)) join `branch` on(`branch`.`branch_id` = `inventory`.`branch_id`))) */;

/*View structure for view vw_stock_in_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_in_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_in_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_in_history` AS (select `stock_in`.`stock_in_id` AS `stock_in_id`,`stock_in`.`ref_no` AS `ref_no`,`stock_in`.`trans_date` AS `trans_date`,`branch`.`branch_address` AS `branch_address`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`stock_in`.`qty` AS `qty`,`supplier`.`supplier_name` AS `supplier_name`,`stock_in`.`remarks` AS `remarks` from (((((((`inventory` join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `stock_in` on(`stock_in`.`inventory_id` = `inventory`.`inventory_id`)) join `supplier` on(`supplier`.`supplier_id` = `stock_in`.`supplier_id`)) join `branch` on(`branch`.`branch_id` = `stock_in`.`branch_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`))) */;

/*View structure for view vw_stock_list */

/*!50001 DROP TABLE IF EXISTS `vw_stock_list` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_list` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_list` AS (select `inventory`.`item_id` AS `item_id`,`branch`.`branch_address` AS `branch_address`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`inventory`.`qty` AS `qty` from (((((`inventory` join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `branch` on(`branch`.`branch_id` = `inventory`.`branch_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`))) */;

/*View structure for view vw_stock_out_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_out_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_out_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_out_history` AS (select `stock_out`.`stock_out_id` AS `stock_out_id`,`stock_out`.`trans_date` AS `trans_date`,`stock_out`.`ref_no` AS `ref_no`,`branch`.`branch_address` AS `branch_address`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`stock_out`.`qty` AS `qty`,`stock_out`.`remarks` AS `remarks` from ((((((`inventory` join `item` on(`item`.`item_id` = `inventory`.`inventory_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `stock_out` on(`stock_out`.`inventory_id` = `inventory`.`inventory_id`)) join `branch` on(`branch`.`branch_id` = `inventory`.`branch_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`))) */;

/*View structure for view vw_stock_ret_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_ret_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_ret_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_ret_history` AS (select `stock_return`.`stock_ret_id` AS `stock_ret_id`,`stock_return`.`trans_date` AS `trans_date`,`stock_return`.`ref_no` AS `ref_no`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`stock_return`.`qty` AS `qty`,`supplier`.`supplier_name` AS `supplier_name`,`branch`.`branch_address` AS `branch_address`,`stock_return`.`remarks` AS `remarks` from (((((((`inventory` join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `stock_return` on(`stock_return`.`inventory_id` = `inventory`.`inventory_id`)) join `supplier` on(`supplier`.`supplier_id` = `stock_return`.`supplier_id`)) join `branch` on(`branch`.`branch_id` = `inventory`.`branch_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`))) */;

/*View structure for view vw_stock_trans_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_trans_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_trans_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_trans_history` AS (select `stock_transfer`.`stock_trans_id` AS `stock_trans_id`,`stock_transfer`.`ref_no` AS `ref_no`,`stock_transfer`.`trans_date` AS `trans_date`,`b_from`.`branch_address` AS `b_from`,`b_to`.`branch_address` AS `b_to`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`stock_transfer`.`qty` AS `qty`,`stock_transfer`.`remarks` AS `remarks` from (((((((`inventory` join `stock_transfer` on(`stock_transfer`.`inventory_id` = `inventory`.`inventory_id`)) join `item` on(`item`.`item_id` = `inventory`.`item_id`)) join `brand` on(`brand`.`brand_id` = `item`.`brand_id`)) join `branch` `b_from` on(`b_from`.`branch_id` = `stock_transfer`.`branch_id_from`)) join `branch` `b_to` on(`b_to`.`branch_id` = `stock_transfer`.`branch_id_to`)) join `category` on(`category`.`category_id` = `item`.`category_id`)) join `unit` on(`unit`.`unit_id` = `item`.`unit_id`))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
