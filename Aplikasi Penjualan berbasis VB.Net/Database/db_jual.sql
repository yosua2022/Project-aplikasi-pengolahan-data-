-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2022 at 06:05 AM
-- Server version: 5.6.20
-- PHP Version: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_jual`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_admin`
--

CREATE TABLE IF NOT EXISTS `tb_admin` (
  `kodeadmin` varchar(6) NOT NULL,
  `namaadmin` varchar(50) NOT NULL,
  `passwordadmin` varchar(30) NOT NULL,
  `leveladmin` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_admin`
--

INSERT INTO `tb_admin` (`kodeadmin`, `namaadmin`, `passwordadmin`, `leveladmin`) VALUES
('ADM01', 'YOSUA', 'ADMIN', 'ADMIN'),
('ADM02', 'ALEX', 'ADMIN', 'ADMIN'),
('ADM03', 'ADMIN', 'Yosua', 'ADMIN');

-- --------------------------------------------------------

--
-- Table structure for table `tb_barang`
--

CREATE TABLE IF NOT EXISTS `tb_barang` (
  `kodebarang` varchar(6) NOT NULL,
  `namabarang` varchar(50) NOT NULL,
  `hargabarang` int(11) NOT NULL,
  `jumlahbarang` int(11) NOT NULL,
  `satuanbarang` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_detailpenjualan`
--

CREATE TABLE IF NOT EXISTS `tb_detailpenjualan` (
  `nopenjualan` varchar(10) NOT NULL,
  `kodebarang` varchar(6) NOT NULL,
  `namabarang` varchar(50) NOT NULL,
  `hargajual` int(11) NOT NULL,
  `jumlahjual` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_detailretur`
--

CREATE TABLE IF NOT EXISTS `tb_detailretur` (
  `noretur` varchar(10) NOT NULL,
  `kodebarang` varchar(6) NOT NULL,
  `namabarang` varchar(100) NOT NULL,
  `hargajual` int(11) NOT NULL,
  `jumlahjual` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_pelanggan`
--

CREATE TABLE IF NOT EXISTS `tb_pelanggan` (
  `kodepelanggan` varchar(6) NOT NULL,
  `namapelanggan` varchar(50) NOT NULL,
  `alamatpelanggan` varchar(100) NOT NULL,
  `telppelanggan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_pelanggan`
--

INSERT INTO `tb_pelanggan` (`kodepelanggan`, `namapelanggan`, `alamatpelanggan`, `telppelanggan`) VALUES
('PLG01', 'Paijo', 'Jl Kartini no 26', '08139856784');

-- --------------------------------------------------------

--
-- Table structure for table `tb_penjualan`
--

CREATE TABLE IF NOT EXISTS `tb_penjualan` (
  `nopenjualan` varchar(10) NOT NULL,
  `tgljual` date NOT NULL,
  `jamjual` time NOT NULL,
  `itemjual` int(11) NOT NULL,
  `totaljual` int(11) NOT NULL,
  `dibayar` int(11) NOT NULL,
  `kembali` int(11) NOT NULL,
  `kodepelanggan` varchar(6) NOT NULL,
  `kodeadmin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_retur`
--

CREATE TABLE IF NOT EXISTS `tb_retur` (
  `noretur` varchar(10) NOT NULL,
  `nopenjualan` varchar(10) NOT NULL,
  `tglretur` date NOT NULL,
  `jamretur` time NOT NULL,
  `itemretur` int(11) NOT NULL,
  `totalretur` int(11) NOT NULL,
  `kodepelanggan` varchar(6) NOT NULL,
  `kodeadmin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_admin`
--
ALTER TABLE `tb_admin`
 ADD PRIMARY KEY (`kodeadmin`);

--
-- Indexes for table `tb_barang`
--
ALTER TABLE `tb_barang`
 ADD PRIMARY KEY (`kodebarang`);

--
-- Indexes for table `tb_pelanggan`
--
ALTER TABLE `tb_pelanggan`
 ADD PRIMARY KEY (`kodepelanggan`);

--
-- Indexes for table `tb_penjualan`
--
ALTER TABLE `tb_penjualan`
 ADD PRIMARY KEY (`nopenjualan`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
