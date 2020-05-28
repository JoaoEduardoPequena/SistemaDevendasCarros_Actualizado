-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema gestao_carros_venda
--

CREATE DATABASE IF NOT EXISTS gestao_carros_venda;
USE gestao_carros_venda;

--
-- Definition of table `tb_carros`
--

DROP TABLE IF EXISTS `tb_carros`;
CREATE TABLE `tb_carros` (
  `cod_carro` int(10) unsigned NOT NULL auto_increment,
  `cod_cat_carro` int(10) unsigned NOT NULL,
  `cod_transmissao` int(10) unsigned NOT NULL,
  `cod_combustivel` int(10) unsigned NOT NULL,
  `modelo_carro` varchar(45) NOT NULL,
  `marca_carro` varchar(45) NOT NULL,
  `kilometragem` varchar(45) NOT NULL,
  `origem` varchar(45) NOT NULL,
  `cor_carro` varchar(45) default NULL,
  `imagem_carro` varchar(900) default NULL,
  PRIMARY KEY  (`cod_carro`),
  KEY `FK_cat_carro` (`cod_cat_carro`),
  KEY `FK_cod_transmissao` (`cod_transmissao`),
  KEY `FK_cod_combustivel` (`cod_combustivel`),
  CONSTRAINT `FK_cod_combustivel` FOREIGN KEY (`cod_combustivel`) REFERENCES `tb_combustivel` (`cod_combustivel`),
  CONSTRAINT `FK_cod_transmissao` FOREIGN KEY (`cod_transmissao`) REFERENCES `tb_transmissao` (`cod_transmissao`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_carros`
--

/*!40000 ALTER TABLE `tb_carros` DISABLE KEYS */;
INSERT INTO `tb_carros` (`cod_carro`,`cod_cat_carro`,`cod_transmissao`,`cod_combustivel`,`modelo_carro`,`marca_carro`,`kilometragem`,`origem`,`cor_carro`,`imagem_carro`) VALUES 
 (1,1,2,1,'Corola','Toyota','120 h','Inglaterra','Vermelho',NULL),
 (3,2,2,1,'Monza','Palio','210 horas','Brasil','Amarelo',NULL),
 (6,1,2,2,'Pálio','Fiat','200 km/h','Americana','Prata',NULL),
 (7,1,2,2,'Cavalo Branco','Ferrari','390 km/h','Americana','Vermelho',NULL),
 (8,1,2,2,'Picante','Suzuki','200 km/h','Americana','Preto',''),
 (10,1,2,2,' I10','Hiundai','900 km/h','Italiana','Preto',''),
 (15,1,1,1,'Tucson','Hyundai','239 km/h','Japonesa','Vermelho',''),
 (16,2,1,2,'Ka','Ford','120 km','Americana','Branco',''),
 (17,2,1,1,'Pálio','Fiat','60 km/h','Italiana','Azul',''),
 (19,1,2,1,'Hilux','Ford','170 km','Holandesa','Verde',''),
 (20,2,2,2,'4x4','Ford','80 km','italiana','Vermelho',''),
 (21,1,2,2,'Auto','Ford','90 km','tailandesa','Cizento',''),
 (22,2,2,2,'SH','Sino Truck','0 km/h','China','Branco','');
/*!40000 ALTER TABLE `tb_carros` ENABLE KEYS */;


--
-- Definition of table `tb_categoria_carro`
--

DROP TABLE IF EXISTS `tb_categoria_carro`;
CREATE TABLE `tb_categoria_carro` (
  `cod_cat_carro` int(10) unsigned NOT NULL auto_increment,
  `nome_cat` varchar(45) NOT NULL,
  PRIMARY KEY  (`cod_cat_carro`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_categoria_carro`
--

/*!40000 ALTER TABLE `tb_categoria_carro` DISABLE KEYS */;
INSERT INTO `tb_categoria_carro` (`cod_cat_carro`,`nome_cat`) VALUES 
 (1,'Ligeiro'),
 (2,'Pesado');
/*!40000 ALTER TABLE `tb_categoria_carro` ENABLE KEYS */;


--
-- Definition of table `tb_combustivel`
--

DROP TABLE IF EXISTS `tb_combustivel`;
CREATE TABLE `tb_combustivel` (
  `cod_combustivel` int(10) unsigned NOT NULL auto_increment,
  `combustivel` varchar(45) NOT NULL,
  PRIMARY KEY  (`cod_combustivel`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_combustivel`
--

/*!40000 ALTER TABLE `tb_combustivel` DISABLE KEYS */;
INSERT INTO `tb_combustivel` (`cod_combustivel`,`combustivel`) VALUES 
 (1,'Gasolina'),
 (2,'Gasoleo');
/*!40000 ALTER TABLE `tb_combustivel` ENABLE KEYS */;


--
-- Definition of table `tb_estoque`
--

DROP TABLE IF EXISTS `tb_estoque`;
CREATE TABLE `tb_estoque` (
  `cod_estoque` int(10) unsigned NOT NULL auto_increment,
  `cod_carro` int(10) unsigned NOT NULL,
  `qtd_estoque` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`cod_estoque`),
  KEY `FK_tb_carro_cod_carro1` (`cod_carro`),
  CONSTRAINT `FK_tb_carro_cod_carro1` FOREIGN KEY (`cod_carro`) REFERENCES `tb_carros` (`cod_carro`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_estoque`
--

/*!40000 ALTER TABLE `tb_estoque` DISABLE KEYS */;
INSERT INTO `tb_estoque` (`cod_estoque`,`cod_carro`,`qtd_estoque`) VALUES 
 (1,8,400),
 (3,7,3),
 (14,15,123),
 (39,3,4),
 (40,16,2),
 (41,17,2),
 (43,19,3),
 (44,20,4),
 (45,21,3),
 (46,1,4),
 (47,22,4);
/*!40000 ALTER TABLE `tb_estoque` ENABLE KEYS */;


--
-- Definition of table `tb_transmissao`
--

DROP TABLE IF EXISTS `tb_transmissao`;
CREATE TABLE `tb_transmissao` (
  `cod_transmissao` int(10) unsigned NOT NULL auto_increment,
  `nome` varchar(45) NOT NULL,
  PRIMARY KEY  (`cod_transmissao`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_transmissao`
--

/*!40000 ALTER TABLE `tb_transmissao` DISABLE KEYS */;
INSERT INTO `tb_transmissao` (`cod_transmissao`,`nome`) VALUES 
 (1,'Automatico'),
 (2,'Mecanico');
/*!40000 ALTER TABLE `tb_transmissao` ENABLE KEYS */;


--
-- Definition of table `tb_usuarios`
--

DROP TABLE IF EXISTS `tb_usuarios`;
CREATE TABLE `tb_usuarios` (
  `cod_usuario` int(10) unsigned NOT NULL auto_increment,
  `nome_usuario` varchar(45) NOT NULL,
  `senha_usuario` varchar(45) NOT NULL,
  `funcao_usuario` varchar(45) NOT NULL,
  PRIMARY KEY  (`cod_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_usuarios`
--

/*!40000 ALTER TABLE `tb_usuarios` DISABLE KEYS */;
INSERT INTO `tb_usuarios` (`cod_usuario`,`nome_usuario`,`senha_usuario`,`funcao_usuario`) VALUES 
 (1,'João Eduardo Pequena','1993','Gestor'),
 (2,'Alberto Natalino Ekumbi','1122','Administrador-Chefe'),
 (6,'Janeth Carlos de Oliveira','2020','Gerente'),
 (7,'Augusto Gomes','eduardo','Vendedor');
/*!40000 ALTER TABLE `tb_usuarios` ENABLE KEYS */;


--
-- Definition of table `tb_venda`
--

DROP TABLE IF EXISTS `tb_venda`;
CREATE TABLE `tb_venda` (
  `id_venda` int(10) unsigned NOT NULL auto_increment,
  `nome` varchar(45) default NULL,
  `cod_usuario` int(10) unsigned default NULL,
  `quantidade_venda` int(10) unsigned NOT NULL,
  `preco_venda` decimal(12,2) NOT NULL,
  `total_venda` decimal(12,2) default NULL,
  `data_venda` varchar(20) default NULL,
  `cod_carro` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`id_venda`),
  KEY `FK_tb_usuario_cod_usuario` (`cod_usuario`),
  KEY `FK_tb_carro_cod_carro` (`cod_carro`),
  CONSTRAINT `FK_tb_carro_cod_carro` FOREIGN KEY (`cod_carro`) REFERENCES `tb_carros` (`cod_carro`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_venda`
--

/*!40000 ALTER TABLE `tb_venda` DISABLE KEYS */;
INSERT INTO `tb_venda` (`id_venda`,`nome`,`cod_usuario`,`quantidade_venda`,`preco_venda`,`total_venda`,`data_venda`,`cod_carro`) VALUES 
 (1,NULL,NULL,1,'90000.00',NULL,'12-11-2016',8),
 (2,NULL,NULL,30,'450000.00',NULL,'13-11-2016',15),
 (3,NULL,NULL,2,'100000.00',NULL,'16-12-2016',7),
 (4,NULL,NULL,2,'670000.00',NULL,'12-11-2016',3),
 (5,NULL,NULL,1,'450000.00',NULL,'12-11-2016',15),
 (6,NULL,NULL,3,'450000.00',NULL,'12-11-2016',8),
 (7,NULL,NULL,3,'230000.00',NULL,'12-11-2016',7),
 (8,NULL,NULL,2,'10.00',NULL,'12-11-2016',8),
 (9,NULL,NULL,2,'20.00',NULL,'12-11-2016',8),
 (10,NULL,NULL,4,'3.00',NULL,'12-11-2016',3),
 (11,NULL,NULL,4,'3.00',NULL,'12-11-2016',15),
 (12,NULL,NULL,4,'3.00',NULL,'12-11-2016',15),
 (13,NULL,NULL,2,'40.00',NULL,'12-11-2016',16),
 (14,NULL,NULL,3,'30.00',NULL,'12-11-2016',19),
 (15,NULL,NULL,4,'60.00',NULL,'12-11-2016',20),
 (16,NULL,NULL,6,'60.00',NULL,'12-11-2016',21),
 (17,NULL,NULL,10,'25.00',NULL,'12-11-2016',20),
 (18,NULL,NULL,2,'100.00',NULL,'12-11-2016',21),
 (19,NULL,NULL,3,'30.00',NULL,'12-11-2016',19);
INSERT INTO `tb_venda` (`id_venda`,`nome`,`cod_usuario`,`quantidade_venda`,`preco_venda`,`total_venda`,`data_venda`,`cod_carro`) VALUES 
 (20,NULL,NULL,2,'20.00',NULL,'12-11-2016',19),
 (21,NULL,NULL,2,'30.00',NULL,'12-11-2016',16),
 (22,NULL,NULL,3,'20.00',NULL,'12-11-2016',16),
 (23,NULL,NULL,2,'50.00',NULL,'12-11-2016',20),
 (24,NULL,NULL,2,'70.00',NULL,'12-11-2016',19),
 (25,NULL,NULL,2,'60.00',NULL,'12-11-2016',15),
 (26,NULL,NULL,1,'5.00',NULL,'12-11-2016',15),
 (27,NULL,NULL,2,'3.00',NULL,'12-11-2016',7),
 (28,NULL,NULL,4,'450.00',NULL,'12-11-2016',21),
 (29,NULL,NULL,2,'19000.00',NULL,'22-11-2016',21),
 (30,NULL,NULL,2,'7000000.00',NULL,'24-11-2016',22);
/*!40000 ALTER TABLE `tb_venda` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
