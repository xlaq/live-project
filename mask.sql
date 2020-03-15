/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50729
Source Host           : localhost:3306
Source Database       : mask

Target Server Type    : MYSQL
Target Server Version : 50729
File Encoding         : 65001

Date: 2020-03-15 20:08:31
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `order`
-- ----------------------------
DROP TABLE IF EXISTS `order`;
CREATE TABLE `order` (
  `order_ID` int(11) NOT NULL,
  `ID_num` varchar(255) DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `phone_num` varchar(255) DEFAULT NULL,
  `mask_num` int(11) DEFAULT NULL,
  PRIMARY KEY (`order_ID`),
  KEY `ID_num` (`ID_num`),
  KEY `phone_num` (`phone_num`),
  KEY `name` (`name`),
  KEY `mask_num` (`mask_num`),
  CONSTRAINT `ID_num` FOREIGN KEY (`ID_num`) REFERENCES `user` (`ID_num`),
  CONSTRAINT `mask_num` FOREIGN KEY (`mask_num`) REFERENCES `user` (`mask_num`),
  CONSTRAINT `name` FOREIGN KEY (`name`) REFERENCES `user` (`name`),
  CONSTRAINT `phone_num` FOREIGN KEY (`phone_num`) REFERENCES `user` (`phone_num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of order
-- ----------------------------
INSERT INTO `order` VALUES ('1', '1', '1', '1', '1');

-- ----------------------------
-- Table structure for `user`
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `name` varchar(255) DEFAULT NULL,
  `ID_num` varchar(255) NOT NULL,
  `phone_num` varchar(255) NOT NULL,
  `subscribe` int(1) NOT NULL,
  `subscribe_num` int(255) DEFAULT NULL,
  `mask_num` int(1) NOT NULL,
  PRIMARY KEY (`ID_num`,`phone_num`),
  KEY `ID_num` (`ID_num`),
  KEY `phone_num` (`phone_num`),
  KEY `name` (`name`),
  KEY `maks_num` (`mask_num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '1', '1', '1', '1', '1');
