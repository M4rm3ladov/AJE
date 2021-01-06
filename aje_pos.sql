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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `branch` */

insert  into `branch`(`branch_id`,`branch_address`) values (1,'Putik'),(2,'Zone 4');

/*Table structure for table `brand` */

DROP TABLE IF EXISTS `brand`;

CREATE TABLE `brand` (
  `brand_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `brand_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`brand_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

/*Data for the table `brand` */

insert  into `brand`(`brand_id`,`brand_name`) values (1,'Firestone'),(2,'Dunlop'),(3,'Bridgestone'),(4,'Shimano'),(5,'Mobil'),(6,'Federal');

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cash_payment` */

insert  into `cash_payment`(`cash_pay_id`,`order_id`,`cashier_id`,`trans_date`,`pay_amount`,`receipt`) values (1,1,2,'2020-12-11','11000.00','29000910001'),(2,2,2,'2020-12-12','11000.00','89999819910'),(3,4,2,'2020-12-11','76000.00','6423111190'),(4,5,2,'2020-12-11','25000.00','77777362772'),(5,6,1,'2020-12-13','2000.00','123'),(6,7,1,'2020-12-13','550.00','123'),(7,10,3,'2020-12-30','8000.00','843917771'),(8,13,3,'2020-12-29','5500.00','182398789'),(9,14,4,'2020-12-29','12700.00','1829198789');

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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cashier` */

insert  into `cashier`(`cashier_id`,`user_id`,`username`,`password`,`salt`,`is_active`,`is_logged_in`) values (1,2,'Bruce123','8ZRlXRgrkHSb6/bvwiitnh3SpDMwK7cxMmDmyX8sXkU=','KUgvirdCvrLNufCiiHaA27DnnrqUTWuGIj2axhlyQDM=',1,0),(2,4,'Peter123','1nYQpr2/bOrXWw/w/L48KeKA2/7x+055lj17ogJkgoU=','wRP1RK+z/OHfAR6FxyD8sVZZvtHsG9RWIxoDkQ4IA7Q=',1,0),(3,5,'Mary123','Y/Tac/F6QofjQiSIJIXqDyye+q9ZV4MIVxevX7lXW/4=','Dj4tNTYANj/z1sbgPCJNf4Q2BqaPsQaIVHh3cylqvtY=',1,0),(4,6,'Betty123','3gzzdMn9ElauLB5r6tukJFQpG4Q/juODDQZFrc7/4aA=','pg+5SF/Fk14ZLaSlKf2kEU/gwch0FVoxV8Gap5Yp2ic=',1,0);

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
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cashier_log` */

insert  into `cashier_log`(`cashier_log_id`,`cashier_id`,`manager_id`,`log_date`,`time_from`,`time_to`,`begin_bal`,`end_bal`) values (1,1,1,'2020-12-11','19:15:49','19:16:35','2000.00','2000.00'),(2,1,1,'2020-12-11','19:19:59','19:51:24','2000.00','2000.00'),(3,1,1,'2020-12-11','19:53:10','19:56:58','2000.00','2000.00'),(4,2,1,'2020-12-11','20:13:26','20:14:24','2000.00','2000.00'),(5,2,1,'2020-12-11','20:19:00','20:23:01','2000.00','12750.00'),(6,2,1,'2020-12-11','20:26:30','20:38:39','2000.00','98790.00'),(7,2,1,'2020-12-11','20:41:49','20:43:24','2000.00','123790.00'),(8,2,1,'2020-12-11','21:00:58','21:03:33','2000.00','123790.00'),(9,2,1,'2020-12-11','21:12:13','21:21:57','0.00','121790.00'),(10,1,1,'2020-12-12','23:38:00',NULL,'2000.00','0.00'),(11,1,1,'2020-12-12','23:43:30',NULL,'2000.00','0.00'),(12,1,1,'2020-12-12','23:52:09','23:52:39','2000.00','2000.00'),(13,1,1,'2020-12-12','23:53:59',NULL,'2000.00','0.00'),(14,1,1,'2020-12-12','23:57:08','23:59:06','2000.00','2000.00'),(15,1,1,'2020-12-13','00:00:55','00:01:34','2000.00','2000.00'),(16,1,1,'2020-12-13','00:03:01','00:03:31','2000.00','2000.00'),(17,1,1,'2020-12-13','00:04:11','00:04:38','2000.00','2000.00'),(18,1,1,'2020-12-13','15:29:14','15:30:36','2000.00','2000.00'),(19,1,1,'2020-12-13','15:34:13','15:36:08','2000.00','2000.00'),(20,1,1,'2020-12-13','16:24:31','16:26:02','2000.00','2000.00'),(21,1,1,'2020-12-13','16:26:30','16:32:14','2000.00','2000.00'),(22,1,1,'2020-12-13','19:23:21',NULL,'2000.00','0.00'),(23,1,1,'2020-12-13','19:29:05','19:31:10','2000.00','4200.00'),(24,1,1,'2020-12-13','19:39:32',NULL,'2000.00','0.00'),(25,1,1,'2020-12-13','19:46:55','19:49:44','2000.00','4200.00'),(26,1,1,'2020-12-13','20:05:00',NULL,'2000.00','0.00'),(27,1,1,'2020-12-13','20:08:49',NULL,'2000.00','0.00'),(28,1,1,'2020-12-13','20:13:03','20:16:58','2000.00','4200.00'),(29,1,1,'2020-12-13','20:43:31','20:46:21','2000.00','4200.00'),(30,1,1,'2020-12-13','20:47:35','21:08:10','2000.00','1500.00'),(31,1,1,'2020-12-13','21:18:56','21:19:41','2000.00','1500.00'),(32,1,1,'2020-12-15','11:32:48','11:33:15','2000.00','2000.00'),(33,3,1,'2020-12-15','11:33:35','11:33:58','4000.00','4000.00'),(34,3,1,'2020-12-15','11:38:03','11:47:04','4000.00','4000.00'),(35,3,1,'2020-12-16','11:48:00','11:48:34','4000.00','4000.00'),(36,3,1,'2020-12-16','11:56:52','11:58:44','4000.00','1340.00'),(37,1,1,'2020-12-16','13:03:42','15:45:56','2300.00','2300.00'),(38,3,1,'2020-12-18','10:15:30',NULL,'4000.00','0.00'),(39,1,1,'2020-12-18','10:21:26',NULL,'4000.00','0.00'),(40,3,1,'2020-12-18','10:36:21',NULL,'4000.00','0.00'),(41,3,1,'2020-12-18','10:40:35','10:41:50','4000.00','-4970.00'),(42,1,1,'2020-12-18','10:44:36','10:46:24','4000.00','-1980.00'),(43,3,1,'2020-12-18','10:47:52','10:51:21','4000.00','-10950.00'),(44,3,1,'2020-12-18','10:58:51',NULL,'4000.00','0.00'),(45,3,1,'2020-12-18','11:06:40','11:09:20','4000.00','-16930.00'),(46,3,1,'2020-12-30','13:44:22','13:46:14','5300.00','5300.00'),(47,3,1,'2020-12-30','13:48:51','13:58:32','5500.00','13500.00'),(48,3,1,'2020-12-30','14:07:41','14:10:03','5500.00','11000.00'),(49,3,1,'2020-12-30','14:15:01','14:17:53','5500.00','8300.00'),(50,3,1,'2020-12-30','14:28:24','14:30:25','5500.00','8300.00'),(51,3,1,'2020-12-29','17:36:03','17:39:11','5000.00','5000.00'),(52,3,1,'2020-12-29','17:41:05','17:47:55','5000.00','5000.00'),(53,3,1,'2020-12-29','17:50:42','17:55:18','5000.00','7800.00'),(54,3,1,'2020-12-29','19:07:22','19:08:18','5000.00','7800.00'),(55,4,1,'2020-12-29','21:50:00','21:54:09','5000.00','21900.00'),(56,4,1,'2020-12-30','21:56:13','22:01:14','5000.00','5000.00'),(57,4,1,'2020-12-30','22:02:56','22:05:26','5000.00','1550.00'),(58,4,1,'2020-12-30','22:06:14','22:10:57','5000.00','8950.00');

/*Table structure for table `category` */

DROP TABLE IF EXISTS `category`;

CREATE TABLE `category` (
  `category_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `category_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `category` */

insert  into `category`(`category_id`,`category_name`) values (1,'Brand New Tires'),(2,'Car Accesories'),(3,'Second Hand Tires'),(4,'Brake'),(5,'Oil');

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

/*Data for the table `credit_payment` */

insert  into `credit_payment`(`credit_pay_id`,`order_id`,`cashier_id`,`customer_id`,`trans_date`,`pay_amount`,`invoice`) values (1,3,2,1,'2020-12-12','8000.00','99901789111'),(2,8,3,1,'2020-12-15','0.00','18988989'),(3,9,3,2,'2020-12-16','0.00','891889991'),(4,11,3,1,'2020-12-30','0.00','112389999'),(5,12,3,1,'2020-12-29','0.00','89198192998'),(6,15,4,3,'2020-12-30','0.00','19290192839'),(7,16,4,1,'2020-12-30','0.00','1234189999');

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `credit_settle` */

insert  into `credit_settle`(`credit_settle_id`,`customer_id`,`cashier_id`,`manager_id`,`trans_date`,`pay_amount`,`receipt`) values (1,1,4,1,'2020-12-29','4200.00',819283789),(2,3,4,1,'2020-12-30','7400.00',832914799);

/*Table structure for table `customer` */

DROP TABLE IF EXISTS `customer`;

CREATE TABLE `customer` (
  `customer_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `customer_code` varchar(30) DEFAULT NULL,
  `credit_limit` decimal(15,2) DEFAULT '0.00',
  `balance` decimal(15,2) DEFAULT '0.00',
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `customer` */

insert  into `customer`(`customer_id`,`customer_code`,`credit_limit`,`balance`) values (1,'cust-001','10000.00','9800.00'),(2,'cust-002','20000.00','14950.00'),(3,'cust-003','30000.00','10000.00');

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

insert  into `customer_details`(`customer_id`,`customer_surname`,`customer_gname`,`customer_mi`,`customer_suffix`) values (1,'Stark','Tony','',''),(2,'Wayne','Bruce','',''),(3,'Bill','Gates',NULL,NULL);

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

/*Data for the table `inventory` */

insert  into `inventory`(`inventory_id`,`item_id`,`branch_id`,`qty`) values (1,1,2,5),(2,2,2,16),(3,3,2,5),(4,4,2,-16),(5,1,1,3),(6,5,2,9),(7,2,1,1),(8,6,2,1),(9,7,2,1);

/*Table structure for table `inventory_period` */

DROP TABLE IF EXISTS `inventory_period`;

CREATE TABLE `inventory_period` (
  `inv_period_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `period_from` date DEFAULT NULL,
  `period_to` date DEFAULT NULL,
  PRIMARY KEY (`inv_period_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `inventory_period` */

insert  into `inventory_period`(`inv_period_id`,`period_from`,`period_to`) values (1,'2020-12-11','2020-12-11');

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

/*Data for the table `item` */

insert  into `item`(`item_id`,`item_code`,`item_desc`,`item_add_desc`,`brand_id`,`category_id`,`unit_id`,`item_unit_price`,`item_price_A`,`item_price_B`) values (1,'item-001','165/60','R14',1,1,3,'2400.00','2600.00','2500.00'),(2,'item-002','165/60','R14',3,1,3,'2500.00','2700.00','2600.00'),(3,'item-003','165/95','R14',2,1,3,'2500.00','2600.00','2550.00'),(4,'item-004','165/90','R14',1,1,3,'2800.00','2990.00','2800.00'),(5,'item-005','Brake Pads','Heavy Duty',4,4,1,'500.00','550.00','530.00'),(6,'item-006','Engine Oil','15L',5,5,1,'50.00','60.00','55.00'),(7,'item-007','165/60','R14',6,1,1,'2700.00','2900.00','2800.00');

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `manager` */

insert  into `manager`(`manager_id`,`user_id`,`username`,`password`,`salt`,`is_active`,`is_logged_in`) values (1,3,'Diana123','S+NaN+tzFe3mSiI1DRZKmtxpwrAvHFnNQI/BtOK2juM=','qh35E9BMmZvD4zbx441Rntxo8cbuBDjNIRIo0tzi6ao=',1,0);

/*Table structure for table `misc` */

DROP TABLE IF EXISTS `misc`;

CREATE TABLE `misc` (
  `critical_stock` bigint(20) DEFAULT '0',
  `credit_limit` decimal(12,2) DEFAULT '10000.00',
  `misc_id` bigint(20) unsigned NOT NULL,
  PRIMARY KEY (`misc_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `misc` */

insert  into `misc`(`critical_stock`,`credit_limit`,`misc_id`) values (3,'30000.00',1);

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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4;

/*Data for the table `order_item_dtls` */

insert  into `order_item_dtls`(`order_item_id`,`order_id`,`inventory_id`,`qty`,`price`,`line_total`) values (1,1,6,1,'550.00','550.00'),(2,1,1,4,'2550.00','10200.00'),(3,2,2,2,'2650.00','5300.00'),(4,2,3,2,'2570.00','5140.00'),(5,3,4,3,'2800.00','8400.00'),(6,4,4,27,'2800.00','75600.00'),(7,5,1,10,'2500.00','25000.00'),(8,6,6,3,'550.00','1650.00'),(9,7,6,1,'550.00','550.00'),(10,8,8,10,'60.00','600.00'),(11,8,1,1,'2600.00','2600.00'),(12,9,4,6,'2990.00','17940.00'),(13,10,2,2,'2700.00','5400.00'),(14,10,1,1,'2600.00','2600.00'),(15,11,2,1,'2700.00','2700.00'),(16,11,1,1,'2500.00','2500.00'),(17,12,3,1,'2600.00','2600.00'),(18,12,1,1,'2600.00','2600.00'),(19,13,2,2,'2700.00','5400.00'),(20,14,9,4,'2900.00','11600.00'),(21,14,6,2,'550.00','1100.00'),(22,15,9,6,'2900.00','17400.00'),(23,16,1,3,'2600.00','7800.00');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `order_svc_dtls` */

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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4;

/*Data for the table `orders` */

insert  into `orders`(`order_id`,`trans_date`,`gross_amount`,`trans_code`,`branch_id`) values (1,'2020-12-11','10750.00',1,2),(2,'2020-12-11','10440.00',2,2),(3,'2020-12-11','8400.00',3,2),(4,'2020-12-11','75600.00',4,2),(5,'2020-12-11','25000.00',5,2),(6,'2020-12-13','1650.00',1,2),(7,'2020-12-13','550.00',2,2),(8,'2020-12-15','3200.00',1,2),(9,'2020-12-15','17940.00',2,2),(10,'2020-12-30','8000.00',1,2),(11,'2020-12-30','5200.00',2,2),(12,'2020-12-29','5200.00',1,2),(13,'2020-12-29','5400.00',1,2),(14,'2020-12-29','12700.00',1,2),(15,'2020-12-30','17400.00',3,2),(16,'2020-12-30','7800.00',4,2);

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `physical_count` */

insert  into `physical_count`(`phys_count_id`,`inv_period_id`,`inventory_id`,`qty`,`count_date`,`ref_no`,`remarks`) values (1,1,1,10,'2020-12-11',1,'');

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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4;

/*Data for the table `refund` */

insert  into `refund`(`refund_id`,`order_id`,`cashier_id`,`manager_id`,`amount`,`trans_date`,`remarks`) values (1,3,1,1,'2700.00','2020-12-13','test'),(2,8,3,1,'2660.00','2020-12-16','test'),(3,9,3,1,'2990.00','2020-12-18','testung'),(4,9,1,1,'2990.00','2020-12-18','testung'),(5,9,3,1,'2990.00','2020-12-18','test lang ng test'),(6,9,3,1,'2990.00','2020-12-18','test ulit ng test'),(7,9,1,1,'2990.00','2020-12-18','sdakfsadkjfaskl'),(8,9,3,1,'2990.00','2020-12-18','hutek'),(9,9,3,1,'2990.00','2020-12-18','fakjdsfkla'),(10,9,3,1,'2990.00','2020-12-18','eoooo!!'),(11,9,3,1,'2990.00','2020-12-18','ay nako'),(12,11,3,1,'2500.00','2020-12-30','helo world'),(13,11,3,1,'2700.00','2020-12-30','world hello'),(14,12,3,1,'2600.00','2020-12-29','akira'),(15,14,4,1,'3450.00','2020-12-30','akdsfajl');

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
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

/*Data for the table `refund_item_dtls` */

insert  into `refund_item_dtls`(`refund_item_id`,`refund_id`,`inventory_id`,`qty`,`price`,`sub_total`) values (1,1,4,1,'2700.00','2700.00'),(2,2,8,1,'60.00','60.00'),(3,2,1,1,'2600.00','2600.00'),(4,3,4,1,'2990.00','2990.00'),(5,4,4,1,'2990.00','2990.00'),(6,5,4,1,'2990.00','2990.00'),(7,6,4,1,'2990.00','2990.00'),(8,7,4,1,'2990.00','2990.00'),(9,8,4,1,'2990.00','2990.00'),(10,9,4,1,'2990.00','2990.00'),(11,10,4,1,'2990.00','2990.00'),(12,11,4,1,'2990.00','2990.00'),(13,12,1,1,'2500.00','2500.00'),(14,13,2,1,'2700.00','2700.00'),(15,14,3,1,'2600.00','2600.00'),(16,15,9,1,'2900.00','2900.00'),(17,15,6,1,'550.00','550.00');

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

insert  into `service`(`service_id`,`service_code`,`service_desc`,`service_fee_A`,`service_fee_B`) values (1,'svc-001','Body Enhancement','5000.00','4000.00'),(2,'svc-002','Change Oil','40.00','30.00');

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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_in` */

insert  into `stock_in`(`stock_in_id`,`inventory_id`,`branch_id`,`supplier_id`,`ref_no`,`qty`,`trans_date`,`remarks`) values (1,1,2,1,1,10,'2020-12-11','initial stock in'),(2,2,2,1,1,10,'2020-12-11','initial stock in'),(3,3,2,1,1,10,'2020-12-11','initial stock in'),(4,4,2,1,1,10,'2020-12-11','initial stock in'),(5,6,2,2,2,5,'2020-12-11','initial stock in for brake'),(6,1,2,1,3,1,'2020-12-13','stock 2 test'),(7,8,2,2,4,10,'2020-12-15','Oil stock'),(8,2,2,2,5,13,'2020-12-15','test stock'),(9,1,2,2,6,13,'2020-12-15','try and try'),(10,6,2,2,7,10,'2020-12-15','try ulit'),(11,2,2,1,8,2,'2020-12-30',''),(12,9,2,3,9,10,'2020-12-29','');

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

insert  into `stock_out`(`stock_out_id`,`inventory_id`,`branch_id`,`ref_no`,`qty`,`trans_date`,`remarks`) values (1,4,2,1,5,'2020-12-11','Expired');

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_return` */

insert  into `stock_return`(`stock_ret_id`,`inventory_id`,`branch_id`,`supplier_id`,`ref_no`,`qty`,`trans_date`,`remarks`) values (1,2,2,1,1,2,'2020-12-11','reject items'),(2,3,2,1,2,3,'2020-12-13','');

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stock_transfer` */

insert  into `stock_transfer`(`stock_trans_id`,`inventory_id`,`branch_id_from`,`branch_id_to`,`ref_no`,`qty`,`trans_date`,`remarks`) values (1,1,2,1,1,3,'2020-12-11',''),(2,2,2,1,2,1,'2020-12-13','test');

/*Table structure for table `supplier` */

DROP TABLE IF EXISTS `supplier`;

CREATE TABLE `supplier` (
  `supplier_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(50) DEFAULT NULL,
  `supplier_address` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `supplier` */

insert  into `supplier`(`supplier_id`,`supplier_name`,`supplier_address`) values (1,'SM City','Mindpro'),(2,'Citi Mall','Tetuan'),(3,'Citi Hardware','kasdla');

/*Table structure for table `unit` */

DROP TABLE IF EXISTS `unit`;

CREATE TABLE `unit` (
  `unit_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `unit_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`unit_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `unit` */

insert  into `unit`(`unit_id`,`unit_name`) values (1,'pieces'),(2,'pack'),(3,'set');

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

insert  into `user_details`(`user_id`,`user_surname`,`user_gname`,`user_mi`,`user_suffix`) values (1,'Antonio','Renier',NULL,NULL),(2,'Wayne','Bruce','',''),(3,'Prince','Diana','',''),(4,'Parker','Peter','',''),(5,'Poppins','Mary','',''),(6,'Boop','Betty','','');

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

/*Data for the table `users` */

insert  into `users`(`user_id`,`branch_id`,`username`,`password`,`salt`,`user_type`,`is_active`,`is_logged_in`) values (1,1,'admin','/smooBQBS4hZPOkeLcnTj+kICixKgwOfLZN8xqKu7q4=','GkflZ7Xr7S/8BudwijKnEgPQ1APSxh3CYI3VJPhHVkg=','Admin',1,0),(2,2,'Bruce123','3AiZ7g/I7ayCbHSF1k3UiAj5MtwHuPoPLR1IDZLK3KY=','EkEQnNhC16AgGXCmDTkJ/YTqt10EEynw63bcYgQQWS0=','Cashier',1,0),(3,2,'Diana123','BouurctVvUoWokgAPDzoj8hRml1Q4yZlU2TTrMEp9t0=','TkEa7myj5brsZCK3Gk2le5yfaUmxLW/tczG0lBg1IDY=','Manager',1,0),(4,2,'Peter123','hKCpNpEea1H5ONBxxArCKx6dVrfjmGjwLHxb8k1oOIE=','grSwXc/t79OdhtTr82thUzvU0SZES0Wu4xOVR3G8idk=','Cashier',1,0),(5,2,'Mary123','0ahUNanoV53xNU3bVetOHrtDLyceqO5TqcqXFc6owzU=','lDIVtuYHCgeeFgpzoQYrRcZ6EAk3ljiRNsTxB2HuHqQ=','Cashier',1,0),(6,2,'Betty123','Gi5hyfc1mNL19HY3Qs0o3F0pD/4zE+UeWtEuLNaMs3A=','sNmrSjSh/EWMFkRB4prHhcLoWEqVrC0X1muj5mgfnR0=','Cashier',1,0);

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

/*Table structure for table `vw_credit_sales` */

DROP TABLE IF EXISTS `vw_credit_sales`;

/*!50001 DROP VIEW IF EXISTS `vw_credit_sales` */;
/*!50001 DROP TABLE IF EXISTS `vw_credit_sales` */;

/*!50001 CREATE TABLE  `vw_credit_sales`(
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
 `trans_date` varchar(17) ,
 `pay_amount` varchar(17) ,
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

/*View structure for view vw_all_sales */

/*!50001 DROP TABLE IF EXISTS `vw_all_sales` */;
/*!50001 DROP VIEW IF EXISTS `vw_all_sales` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_all_sales` AS (select `orders`.`trans_date` AS `DateInputed`,`credit_payment`.`trans_date` AS `transDate`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`credit_payment`.`invoice` AS `invoice`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from ((((((((((`orders` join `order_item_dtls` on((`order_item_dtls`.`order_id` = `orders`.`order_id`))) join `inventory` on((`inventory`.`inventory_id` = `order_item_dtls`.`inventory_id`))) join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `credit_payment` on((`credit_payment`.`order_id` = `orders`.`order_id`))) join `cashier` on((`cashier`.`cashier_id` = `credit_payment`.`cashier_id`))) join `user_details` on((`user_details`.`user_id` = `cashier`.`user_id`))) join `customer_details` on((`customer_details`.`customer_id` = `credit_payment`.`customer_id`)))) union (select `orders`.`trans_date` AS `DateInputed`,`credit_payment`.`trans_date` AS `transDate`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`credit_payment`.`invoice` AS `invoice`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from ((((((`orders` join `order_svc_dtls` on((`order_svc_dtls`.`order_id` = `orders`.`order_id`))) join `service` on((`service`.`service_id` = `order_svc_dtls`.`service_id`))) join `credit_payment` on((`credit_payment`.`order_id` = `orders`.`order_id`))) join `cashier` on((`cashier`.`cashier_id` = `credit_payment`.`cashier_id`))) join `user_details` on((`user_details`.`user_id` = `cashier`.`user_id`))) join `customer_details` on((`customer_details`.`customer_id` = `credit_payment`.`customer_id`)))) union (select `orders`.`trans_date` AS `DateInputed`,`cash_payment`.`trans_date` AS `transDate`,'' AS `Customers`,`cash_payment`.`receipt` AS `receipt`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((((((`orders` join `order_item_dtls` on((`orders`.`order_id` = `order_item_dtls`.`order_id`))) join `inventory` on((`order_item_dtls`.`inventory_id` = `inventory`.`inventory_id`))) join `item` on((`inventory`.`item_id` = `item`.`item_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `brand` on((`item`.`brand_id` = `brand`.`brand_id`))) join `cash_payment` on((`orders`.`order_id` = `cash_payment`.`order_id`))) join `cashier` on((`cash_payment`.`cashier_id` = `cashier`.`cashier_id`))) join `user_details` on((`cashier`.`user_id` = `user_details`.`user_id`)))) union (select `orders`.`trans_date` AS `DateInputed`,`cash_payment`.`trans_date` AS `transDate`,'' AS `Customers`,`cash_payment`.`receipt` AS `receipt`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((`orders` join `order_svc_dtls` on((`order_svc_dtls`.`order_id` = `orders`.`order_id`))) join `service` on((`service`.`service_id` = `order_svc_dtls`.`service_id`))) join `cash_payment` on((`orders`.`order_id` = `cash_payment`.`order_id`))) join `cashier` on((`cash_payment`.`cashier_id` = `cashier`.`cashier_id`))) join `user_details` on((`cashier`.`user_id` = `user_details`.`user_id`)))) */;

/*View structure for view vw_cash_in */

/*!50001 DROP TABLE IF EXISTS `vw_cash_in` */;
/*!50001 DROP VIEW IF EXISTS `vw_cash_in` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cash_in` AS select `users`.`branch_id` AS `branch_id`,`cash_in`.`trans_date` AS `trans_date`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`cash_in`.`amount` AS `amount`,`cash_in`.`remarks` AS `remarks` from ((((((`cash_in` join `cashier` on((`cashier`.`cashier_id` = `cash_in`.`cashier_id`))) join `manager` on((`manager`.`manager_id` = `cash_in`.`manager_id`))) join `users` on((`users`.`user_id` = `cashier`.`user_id`))) join `user_details` `m` on((`m`.`user_id` = `manager`.`user_id`))) join `user_details` `c` on((`c`.`user_id` = `cashier`.`user_id`))) join `branch` on((`branch`.`branch_id` = `users`.`branch_id`))) */;

/*View structure for view vw_cash_out */

/*!50001 DROP TABLE IF EXISTS `vw_cash_out` */;
/*!50001 DROP VIEW IF EXISTS `vw_cash_out` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cash_out` AS select `users`.`branch_id` AS `branch_id`,`cash_out`.`trans_date` AS `trans_date`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`cash_out`.`amount` AS `amount`,`cash_out`.`remarks` AS `remarks` from ((((((`cash_out` join `cashier` on((`cashier`.`cashier_id` = `cash_out`.`cashier_id`))) join `manager` on((`manager`.`manager_id` = `cash_out`.`manager_id`))) join `users` on((`users`.`user_id` = `cashier`.`user_id`))) join `user_details` `m` on((`m`.`user_id` = `manager`.`user_id`))) join `user_details` `c` on((`c`.`user_id` = `cashier`.`user_id`))) join `branch` on((`branch`.`branch_id` = `users`.`branch_id`))) */;

/*View structure for view vw_cash_sales */

/*!50001 DROP TABLE IF EXISTS `vw_cash_sales` */;
/*!50001 DROP VIEW IF EXISTS `vw_cash_sales` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cash_sales` AS (select `orders`.`trans_date` AS `DateInputed`,`cash_payment`.`trans_date` AS `transDate`,`cash_payment`.`receipt` AS `receipt`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((((((`orders` join `order_item_dtls` on((`orders`.`order_id` = `order_item_dtls`.`order_id`))) join `inventory` on((`order_item_dtls`.`inventory_id` = `inventory`.`inventory_id`))) join `item` on((`inventory`.`item_id` = `item`.`item_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `brand` on((`item`.`brand_id` = `brand`.`brand_id`))) join `cash_payment` on((`orders`.`order_id` = `cash_payment`.`order_id`))) join `cashier` on((`cash_payment`.`cashier_id` = `cashier`.`cashier_id`))) join `user_details` on((`cashier`.`user_id` = `user_details`.`user_id`)))) union (select `orders`.`trans_date` AS `DateInputed`,`cash_payment`.`trans_date` AS `transDate`,`cash_payment`.`receipt` AS `receipt`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((`orders` join `order_svc_dtls` on((`order_svc_dtls`.`order_id` = `orders`.`order_id`))) join `service` on((`service`.`service_id` = `order_svc_dtls`.`service_id`))) join `cash_payment` on((`orders`.`order_id` = `cash_payment`.`order_id`))) join `cashier` on((`cash_payment`.`cashier_id` = `cashier`.`cashier_id`))) join `user_details` on((`cashier`.`user_id` = `user_details`.`user_id`)))) order by `transDate`,`receipt` */;

/*View structure for view vw_cashier_log */

/*!50001 DROP TABLE IF EXISTS `vw_cashier_log` */;
/*!50001 DROP VIEW IF EXISTS `vw_cashier_log` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cashier_log` AS select `users`.`branch_id` AS `branch_id`,`cashier_log`.`log_date` AS `log_date`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`cashier_log`.`time_from` AS `time_from`,`cashier_log`.`time_to` AS `time_to`,`cashier_log`.`begin_bal` AS `begin_bal`,`cashier_log`.`end_bal` AS `end_bal` from (((((`cashier_log` join `cashier` on((`cashier`.`cashier_id` = `cashier_log`.`cashier_id`))) join `manager` on((`manager`.`manager_id` = `cashier_log`.`manager_id`))) join `users` on((`users`.`user_id` = `cashier`.`user_id`))) join `user_details` `c` on((`c`.`user_id` = `cashier`.`user_id`))) join `user_details` `m` on((`m`.`user_id` = `manager`.`user_id`))) order by `cashier_log`.`log_date`,`cashier_log`.`cashier_id` */;

/*View structure for view vw_credit_sales */

/*!50001 DROP TABLE IF EXISTS `vw_credit_sales` */;
/*!50001 DROP VIEW IF EXISTS `vw_credit_sales` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_credit_sales` AS (select `orders`.`trans_date` AS `DateInputed`,`credit_payment`.`trans_date` AS `transDate`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`credit_payment`.`invoice` AS `invoice`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from ((((((((((`orders` join `order_item_dtls` on((`order_item_dtls`.`order_id` = `orders`.`order_id`))) join `inventory` on((`inventory`.`inventory_id` = `order_item_dtls`.`inventory_id`))) join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `credit_payment` on((`credit_payment`.`order_id` = `orders`.`order_id`))) join `cashier` on((`cashier`.`cashier_id` = `credit_payment`.`cashier_id`))) join `user_details` on((`user_details`.`user_id` = `cashier`.`user_id`))) join `customer_details` on((`customer_details`.`customer_id` = `credit_payment`.`customer_id`)))) union (select `orders`.`trans_date` AS `DateInputed`,`credit_payment`.`trans_date` AS `transDate`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`credit_payment`.`invoice` AS `invoice`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from ((((((`orders` join `order_svc_dtls` on((`order_svc_dtls`.`order_id` = `orders`.`order_id`))) join `service` on((`service`.`service_id` = `order_svc_dtls`.`service_id`))) join `credit_payment` on((`credit_payment`.`order_id` = `orders`.`order_id`))) join `cashier` on((`cashier`.`cashier_id` = `credit_payment`.`cashier_id`))) join `user_details` on((`user_details`.`user_id` = `cashier`.`user_id`))) join `customer_details` on((`customer_details`.`customer_id` = `credit_payment`.`customer_id`)))) order by `transDate`,`invoice` */;

/*View structure for view vw_customer_balance */

/*!50001 DROP TABLE IF EXISTS `vw_customer_balance` */;
/*!50001 DROP VIEW IF EXISTS `vw_customer_balance` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_customer_balance` AS select concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`) AS `Customers`,`customer`.`credit_limit` AS `credit_limit`,`customer`.`balance` AS `balance` from (`customer` join `customer_details` on((`customer`.`customer_id` = `customer_details`.`customer_id`))) */;

/*View structure for view vw_customer_payments */

/*!50001 DROP TABLE IF EXISTS `vw_customer_payments` */;
/*!50001 DROP VIEW IF EXISTS `vw_customer_payments` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_customer_payments` AS select `credit_settle`.`trans_date` AS `trans_date`,`credit_settle`.`receipt` AS `receipt`,concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`) AS `Customers`,`credit_settle`.`pay_amount` AS `pay_amount`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers` from (((((`credit_settle` join `manager` on((`manager`.`manager_id` = `credit_settle`.`manager_id`))) join `cashier` on((`cashier`.`cashier_id` = `credit_settle`.`cashier_id`))) join `customer_details` on((`customer_details`.`customer_id` = `credit_settle`.`customer_id`))) join `user_details` `c` on((`c`.`user_id` = `cashier`.`user_id`))) join `user_details` `m` on((`m`.`user_id` = `manager`.`user_id`))) order by `credit_settle`.`trans_date`,`credit_settle`.`receipt` */;

/*View structure for view vw_customer_transactions */

/*!50001 DROP TABLE IF EXISTS `vw_customer_transactions` */;
/*!50001 DROP VIEW IF EXISTS `vw_customer_transactions` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_customer_transactions` AS (select concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`customer`.`customer_id` AS `customer_id`,`credit_payment`.`trans_date` AS `trans_date`,`credit_payment`.`pay_amount` AS `pay_amount`,`credit_payment`.`invoice` AS `invoice`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`order_item_dtls`.`price` AS `price`,`order_item_dtls`.`qty` AS `qty`,`order_item_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((((((((`orders` join `credit_payment` on((`credit_payment`.`order_id` = `orders`.`order_id`))) join `order_item_dtls` on((`order_item_dtls`.`order_id` = `orders`.`order_id`))) join `inventory` on((`inventory`.`inventory_id` = `order_item_dtls`.`inventory_id`))) join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`))) join `cashier` on((`credit_payment`.`cashier_id` = `cashier`.`cashier_id`))) join `user_details` on((`user_details`.`user_id` = `cashier`.`user_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `customer` on((`customer`.`customer_id` = `credit_payment`.`customer_id`))) join `customer_details` on((`customer_details`.`customer_id` = `credit_payment`.`customer_id`)))) union (select concat(`customer_details`.`customer_gname`,' ',`customer_details`.`customer_surname`,' ',`customer_details`.`customer_suffix`) AS `Customers`,`customer`.`customer_id` AS `customer_id`,`credit_payment`.`pay_amount` AS `pay_amount`,`credit_payment`.`trans_date` AS `trans_date`,`credit_payment`.`invoice` AS `invoice`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`order_svc_dtls`.`price` AS `price`,`order_svc_dtls`.`qty` AS `qty`,`order_svc_dtls`.`line_total` AS `line_total`,concat(`user_details`.`user_gname`,' ',`user_details`.`user_surname`,' ',`user_details`.`user_suffix`) AS `Cashiers`,`orders`.`branch_id` AS `branch_id` from (((((((`orders` join `credit_payment` on((`credit_payment`.`order_id` = `orders`.`order_id`))) join `order_svc_dtls` on((`order_svc_dtls`.`order_id` = `orders`.`order_id`))) join `service` on((`service`.`service_id` = `order_svc_dtls`.`service_id`))) join `cashier` on((`credit_payment`.`cashier_id` = `cashier`.`cashier_id`))) join `user_details` on((`user_details`.`user_id` = `cashier`.`user_id`))) join `customer` on((`customer`.`customer_id` = `credit_payment`.`customer_id`))) join `customer_details` on((`customer_details`.`customer_id` = `credit_payment`.`customer_id`)))) order by `trans_date`,`invoice` */;

/*View structure for view vw_refund */

/*!50001 DROP TABLE IF EXISTS `vw_refund` */;
/*!50001 DROP VIEW IF EXISTS `vw_refund` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_refund` AS (select `refund`.`trans_date` AS `trans_date`,concat(`brand`.`brand_name`,' | ',`item`.`item_desc`,' | ',`item`.`item_add_desc`) AS `Description`,`category`.`category_name` AS `Category`,`unit`.`unit_name` AS `Unit`,`refund_item_dtls`.`price` AS `price`,`refund_item_dtls`.`qty` AS `qty`,`refund_item_dtls`.`sub_total` AS `sub_total`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`refund`.`remarks` AS `remarks`,`orders`.`branch_id` AS `branch_id` from (((((((((((`refund` join `refund_item_dtls` on((`refund_item_dtls`.`refund_id` = `refund`.`refund_id`))) join `inventory` on((`inventory`.`inventory_id` = `refund_item_dtls`.`inventory_id`))) join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `cashier` on((`cashier`.`cashier_id` = `refund`.`cashier_id`))) join `user_details` `c` on((`c`.`user_id` = `cashier`.`user_id`))) join `manager` on((`manager`.`manager_id` = `refund`.`manager_id`))) join `user_details` `m` on((`m`.`user_id` = `manager`.`manager_id`))) join `orders` on((`orders`.`order_id` = `refund`.`order_id`)))) union (select `refund`.`trans_date` AS `trans_date`,`service`.`service_desc` AS `Description`,'' AS `Category`,'' AS `Unit`,`refund_svc_dtls`.`price` AS `price`,`refund_svc_dtls`.`qty` AS `qty`,`refund_svc_dtls`.`sub_total` AS `sub_total`,concat(`c`.`user_gname`,' ',`c`.`user_surname`) AS `Cashiers`,concat(`m`.`user_gname`,' ',`m`.`user_surname`) AS `Managers`,`refund`.`remarks` AS `remarks`,`orders`.`branch_id` AS `branch_id` from (((((((`refund` join `refund_svc_dtls` on((`refund_svc_dtls`.`refund_id` = `refund`.`refund_id`))) join `service` on((`service`.`service_id` = `refund_svc_dtls`.`service_id`))) join `cashier` on((`cashier`.`cashier_id` = `refund`.`cashier_id`))) join `user_details` `c` on((`c`.`user_id` = `cashier`.`user_id`))) join `manager` on((`manager`.`manager_id` = `refund`.`manager_id`))) join `user_details` `m` on((`m`.`user_id` = `manager`.`manager_id`))) join `orders` on((`orders`.`order_id` = `refund`.`order_id`)))) */;

/*View structure for view vw_stock_adjust_history */

/*!50001 DROP TABLE IF EXISTS `vw_stock_adjust_history` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock_adjust_history` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_adjust_history` AS (select `physical_count`.`phys_count_id` AS `phys_count_id`,`physical_count`.`count_date` AS `count_date`,`item`.`item_code` AS `item_code`,`brand`.`brand_name` AS `brand_name`,`item`.`item_desc` AS `item_desc`,`item`.`item_add_desc` AS `item_add_desc`,`category`.`category_name` AS `category_name`,`unit`.`unit_name` AS `unit_name`,`branch`.`branch_address` AS `branch_address`,`physical_count`.`qty` AS `qty`,`physical_count`.`ref_no` AS `ref_no`,`inventory_period`.`period_from` AS `period_from`,`inventory_period`.`period_to` AS `period_to` from (((((((`inventory` join `physical_count` on((`physical_count`.`inventory_id` = `inventory`.`inventory_id`))) join `inventory_period` on((`inventory_period`.`inv_period_id` = `physical_count`.`inv_period_id`))) join `item` on((`item`.`item_id` = `inventory`.`item_id`))) join `brand` on((`brand`.`brand_id` = `item`.`brand_id`))) join `category` on((`category`.`category_id` = `item`.`category_id`))) join `unit` on((`unit`.`unit_id` = `item`.`unit_id`))) join `branch` on((`branch`.`branch_id` = `inventory`.`branch_id`)))) */;

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
