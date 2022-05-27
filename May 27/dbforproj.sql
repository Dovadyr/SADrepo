-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 27, 2022 at 10:54 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbforproj`
--

-- --------------------------------------------------------

--
-- Table structure for table `receiptdb`
--

CREATE TABLE `receiptdb` (
  `trans_num` int(11) NOT NULL,
  `cus_name` varchar(266) DEFAULT NULL,
  `phone_num` varchar(15) DEFAULT NULL,
  `deli_address` varchar(266) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `item1` int(11) DEFAULT NULL,
  `item2` int(11) DEFAULT NULL,
  `item3` int(11) DEFAULT NULL,
  `item4` int(11) DEFAULT NULL,
  `item5` int(11) DEFAULT NULL,
  `total` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `receiptdb`
--

INSERT INTO `receiptdb` (`trans_num`, `cus_name`, `phone_num`, `deli_address`, `trans_date`, `item1`, `item2`, `item3`, `item4`, `item5`, `total`) VALUES
(1, 'Lolo Jess', '09887990921', 'Santa Cruz, Laguna', '2022-05-27', 1, 0, 0, 0, 2, 5900),
(2, 'Acer Company', '09990965211', 'Cabuyao, Laguna', '2022-05-27', 0, 0, 0, 10, 20, 155000),
(3, 'Harry Potter', '0999999999', 'Binan, Laguna', '2022-05-27', 1, 0, 3, 0, 0, 35397);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `receiptdb`
--
ALTER TABLE `receiptdb`
  ADD PRIMARY KEY (`trans_num`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `receiptdb`
--
ALTER TABLE `receiptdb`
  MODIFY `trans_num` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
