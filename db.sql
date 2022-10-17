/*
SQLyog Community v13.1.9 (64 bit)
MySQL - 8.0.31 : Database - teverk
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`teverk` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `teverk`;

/*Table structure for table `actor_tvshow` */

DROP TABLE IF EXISTS `actor_tvshow`;

CREATE TABLE `actor_tvshow` (
  `id` int NOT NULL AUTO_INCREMENT,
  `actor_id` int DEFAULT NULL,
  `tvshow_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `actor_tvshow` */

insert  into `actor_tvshow`(`id`,`actor_id`,`tvshow_id`) values 
(1,1,1),
(2,2,1);

/*Table structure for table `actors` */

DROP TABLE IF EXISTS `actors`;

CREATE TABLE `actors` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `age` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `actors` */

insert  into `actors`(`id`,`name`,`age`) values 
(1,'Jay Hernandez',25),
(2,'Perdita Weeks',23);

/*Table structure for table `episodes` */

DROP TABLE IF EXISTS `episodes`;

CREATE TABLE `episodes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `temp` int NOT NULL,
  `duration` int NOT NULL,
  `release_date` varchar(255) NOT NULL,
  `tvshow_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `episodes` */

insert  into `episodes`(`id`,`name`,`temp`,`duration`,`release_date`,`tvshow_id`) values 
(1,'Piloto',1,30,'01-01-2022',1),
(3,'Piloto',1,22,'01-01-2022',2);

/*Table structure for table `genres` */

DROP TABLE IF EXISTS `genres`;

CREATE TABLE `genres` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `genres` */

insert  into `genres`(`id`,`name`) values 
(1,'Action'),
(2,'Horror'),
(3,'Thriller'),
(4,'Anime');

/*Table structure for table `tv_shows` */

DROP TABLE IF EXISTS `tv_shows`;

CREATE TABLE `tv_shows` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `genre` int NOT NULL,
  `type` varchar(1) NOT NULL,
  `favorite` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tv_shows` */

insert  into `tv_shows`(`id`,`name`,`author`,`genre`,`type`,`favorite`) values 
(1,'Magnum PI ','Universal',1,'S',1),
(2,'Naruto','TokyoTV',0,'S',0);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
