---- phpMyAdmin SQL Dump
---- version 5.2.1
---- https://www.phpmyadmin.net/
----
---- Host: 127.0.0.1
---- Generation Time: Apr 23, 2024 at 07:39 AM
---- Server version: 10.4.32-MariaDB
---- PHP Version: 8.0.30

--SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
--START TRANSACTION;
--SET time_zone = "+00:00";


--/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
--/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
--/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
--/*!40101 SET NAMES utf8mb4 */;

----
---- Database: `krepsinio_varzybos`
----

---- --------------------------------------------------------

----
---- Table structure for table `arenos`
----

--CREATE TABLE `arenos` (
--  `Salis` varchar(20) NOT NULL,
--  `Miestas` varchar(20) NOT NULL,
--  `Savininkas` varchar(40) DEFAULT NULL,
--  `Pavadinimas` varchar(20) NOT NULL,
--  `Talpa` int(11) NOT NULL,
--  `Atidarymas` date DEFAULT NULL,
--  `id_Arena` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `arenos`
----

--INSERT INTO `arenos` (`Salis`, `Miestas`, `Savininkas`, `Pavadinimas`, `Talpa`, `Atidarymas`, `id_Arena`) VALUES
--('Prancūzija', 'Orleans', 'Orleans Loiret Basket', 'Le Zénith', 6000, '1996-01-01', 1),
--('Italija', 'Milanas', 'Pallacanestro Olimpia Milano', 'Mediolanum Forum', 12500, '1990-04-16', 2),
--('Anglija', 'Londonas', 'Anschutz Entertain.', 'The O2 Arena', 20000, '2007-06-24', 3),
--('Vokietija', 'Berlynas', 'ALBA Berlin', 'Mercedes-Benz Arena', 17500, '2008-09-10', 4),
--('Rusija', 'Maskva', 'CSKA Moscow', 'Megasport Arena', 14000, '2006-01-29', 5),
--('Turkija', 'Stambulas', 'Turkish Basketball Fed.', 'Sinan Erdem Dome', 16000, '2010-03-11', 6),
--('Brazilija', 'San Paulu', 'Assoc. Desportiva São C.', 'Ibirapuera Gym', 12000, '1957-01-11', 7),
--('Argentina', 'Buenos Airėsas', 'Government of Buenos A.', 'Luna Park', 13000, '1932-07-11', 8),
--('Vokietija', 'Miunchenas', 'FC Bayern Munich BB', 'Audi Dome', 6700, '1972-03-01', 9),
--('Portugalija', 'Guimares', 'Vitória S.C. Basketball', 'Pav. Multiusos G.', 4000, '2001-12-14', 10);

---- --------------------------------------------------------

----
---- Table structure for table `darbuotojai`
----

--CREATE TABLE `darbuotojai` (
--  `Vardas` varchar(20) NOT NULL,
--  `Pavarde` varchar(20) NOT NULL,
--  `Pareigos` varchar(20) NOT NULL,
--  `Patirtis` int(11) NOT NULL,
--  `id_Darbuotojas` int(11) NOT NULL,
--  `fk_Sekretoriatasid_Sekretoriatas` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `darbuotojai`
----

--INSERT INTO `darbuotojai` (`Vardas`, `Pavarde`, `Pareigos`, `Patirtis`, `id_Darbuotojas`, `fk_Sekretoriatasid_Sekretoriatas`) VALUES
--('John', 'Doe', 'Aikštės vadovas', 5, 1, 1),
--('Jane', 'Smith', 'Pranešėjas', 3, 2, 2),
--('Michael', 'Johnson', 'Kamerų operatorius', 2, 3, 3),
--('Emily', 'Brown', 'Rezultato sekėjas', 4, 4, 4),
--('David', 'Martinez', 'Rezultato sekėjas', 6, 5, 5),
--('Sarah', 'Jones', 'Aikštės vadovas', 8, 6, 6),
--('Matthew', 'Davis', 'Kamerų operatorius', 3, 7, 7),
--('Jessica', 'Wilson', 'Aikštės vadovas', 7, 8, 8),
--('Christopher', 'Taylor', 'Pranešėjas', 5, 9, 9),
--('Amanda', 'Anderson', 'Rezultato sekėjas', 4, 10, 10),
--('Robert', 'Wilson', 'Garso technikas', 6, 11, 1),
--('Michelle', 'Thomas', 'Aikštės vadovas', 4, 12, 2),
--('Daniel', 'White', 'Pranešėjas', 5, 13, 3),
--('Jennifer', 'Harris', 'Rezultato sekėjas', 3, 14, 4),
--('Kevin', 'Martin', 'Garso technikas', 7, 15, 5),
--('Linda', 'Garcia', 'Garso technikas', 8, 16, 6),
--('William', 'Lee', 'Aikštės vadovas', 3, 17, 7),
--('Melissa', 'Walker', 'Pranešėjas', 6, 18, 8),
--('Edward', 'Lewis', 'Aikštės vadovas', 4, 19, 9),
--('Kimberly', 'Allen', 'Pranešėjas', 5, 20, 10);

---- --------------------------------------------------------

----
---- Table structure for table `karjeros_etapai`
----

--CREATE TABLE `karjeros_etapai` (
--  `Pradzios_data` date NOT NULL,
--  `Pabaigos_data` date NOT NULL,
--  `Komanda` varchar(40) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
--  `id_Karjeros_etapas` int(11) NOT NULL,
--  `fk_Zaidejasid_Zaidejas` int(11) NOT NULL,
--  `fk_Pareigosid_Pareigos` int(10) UNSIGNED DEFAULT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `karjeros_etapai`
----

--INSERT INTO `karjeros_etapai` (`Pradzios_data`, `Pabaigos_data`, `Komanda`, `id_Karjeros_etapas`, `fk_Zaidejasid_Zaidejas`, `fk_Pareigosid_Pareigos`) VALUES
--('2012-01-01', '2014-07-01', 'NCAA Career', 6, 2, 3),
--('2014-07-01', '2016-07-01', 'Drafted by NBA Team', 7, 2, 1),
--('2016-07-01', '2020-07-01', 'Stint in G-League', 8, 2, 2),
--('2008-01-01', '2012-07-01', 'Rookie', 9, 3, 2),
--('2012-07-01', '2019-07-01', 'Oklahoma City Thunder', 10, 3, 3),
--('2019-07-01', '2020-07-01', 'Houston Rockets', 11, 3, 1),
--('2020-07-01', '2021-12-31', 'Washington Wizards', 12, 3, 1),
--('2017-01-01', '2019-07-01', 'Charlotte Hornets', 15, 6, 3),
--('2019-07-01', '2021-07-01', 'Los Angeles Lakers', 16, 6, 4),
--('2019-01-01', '2021-07-01', 'Los Angeles Lakers (Early Career)', 17, 7, 4),
--('2009-01-01', '2012-07-01', 'Minnesota Timberwolves', 18, 8, 2),
--('2012-07-01', '2013-07-01', 'Cleveland Cavaliers', 19, 8, 1),
--('2013-07-01', '2014-07-01', 'Dallas Mavericks', 20, 8, 3),
--('2014-07-01', '2015-07-01', 'Los Angeles Lakers', 21, 8, 2),
--('2019-01-01', '2021-07-01', 'Miami Heat', 22, 9, 3),
--('2008-01-01', '2019-07-01', 'Los Angeles Clippers', 23, 10, 4),
--('2019-07-01', '2020-07-01', 'New York Knicks', 24, 10, 4),
--('2020-07-01', '2021-07-01', 'Brooklyn Nets', 25, 10, 1),
--('2004-01-01', '2006-07-01', 'New York Knicks', 26, 11, 2),
--('2006-07-01', '2007-07-01', 'Orlando Magic', 27, 11, 3),
--('2007-07-01', '2009-07-01', 'Los Angeles Lakers', 28, 11, 2),
--('2012-01-01', '2014-07-01', 'Golden State Warriors', 29, 12, 3),
--('2014-07-01', '2019-07-01', 'Atlanta Hawks', 30, 12, 2),
--('2019-07-01', '2020-07-01', 'Portland Trail Blazers', 31, 12, 2),
--('2008-01-01', '2010-07-01', 'Lokomotiv Kuban', 32, 13, 4),
--('2010-07-01', '2015-07-01', 'CSKA Moscow', 33, 13, 3),
--('2012-01-01', '2015-07-01', 'Baskonia', 34, 14, 2),
--('2015-07-01', '2017-07-01', 'Panathinaikos', 35, 14, 1),
--('2017-07-01', '2018-07-01', 'CSKA Moscow', 36, 14, 2),
--('2013-01-01', '2014-07-01', 'Hapoel Holon', 37, 15, 1),
--('2014-07-01', '2015-07-01', 'Darüşşafaka', 38, 15, 4),
--('2015-07-01', '2017-07-01', 'CSKA Moscow', 39, 15, 1),
--('2015-01-01', '2017-07-01', 'Detroit Pistons', 40, 16, 4),
--('2017-07-01', '2018-07-01', 'San Antonio Spurs', 41, 16, 3),
--('2018-07-01', '2019-07-01', 'Khimki', 42, 16, 1),
--('2009-01-01', '2012-07-01', 'Benetton Basket', 43, 17, 2),
--('2012-07-01', '2015-07-01', 'Montepaschi Siena', 44, 17, 2),
--('2015-07-01', '2017-07-01', 'Olympiacos', 45, 17, 3),
--('2012-01-01', '2014-07-01', 'Spirou Charleroi', 46, 18, 2),
--('2014-07-01', '2017-07-01', 'Baskonia', 47, 18, 2),
--('2017-07-01', '2020-07-01', 'CSKA Moscow', 48, 18, 1),
--('2016-01-01', '2018-07-01', 'Utah Jazz', 49, 19, 2),
--('2018-07-01', '2019-07-01', 'Milwaukee Bucks', 50, 19, 1),
--('2019-07-01', '2020-07-01', 'Cleveland Cavaliers', 51, 19, 3),
--('2015-01-01', '2017-07-01', 'Partizan', 52, 20, 3),
--('2017-07-01', '2020-07-01', 'Olympiacos', 53, 20, 4),
--('2020-07-01', '2021-07-01', 'CSKA Moscow', 54, 20, 4),
--('2010-01-01', '2014-07-01', 'Buducnost', 55, 21, 3),
--('2014-07-01', '2017-07-01', 'Budućnost VOLI', 56, 21, 2),
--('2017-07-01', '2021-07-01', 'Zenit Saint Petersburg', 57, 21, 1),
--('2015-01-01', '2018-07-01', 'Bakken Bears', 58, 22, 2),
--('2018-07-01', '2021-07-01', 'Zielona Góra', 59, 22, 1),
--('2021-07-01', '2022-07-01', 'Zalgiris Kaunas', 60, 22, 3),
--('2000-01-01', '2003-07-01', 'Iraklis Thessaloniki', 61, 23, 2),
--('2003-07-01', '2005-07-01', 'AEK Athens', 62, 23, 3),
--('2005-07-01', '2007-07-01', 'Benetton Treviso', 63, 23, 1),
--('2003-01-01', '2006-07-01', 'Estudiantes', 64, 24, 3),
--('2006-07-01', '2010-07-01', 'Portland Trail Blazers', 65, 24, 2),
--('2010-07-01', '2012-07-01', 'New York Knicks', 66, 24, 2),
--('2003-01-01', '2011-07-01', 'Denver Nuggets', 68, 4, 1),
--('2011-07-01', '2017-07-01', 'New York Knicks', 69, 4, 4),
--('2010-07-01', '2014-07-01', 'Miami Heat', 80, 1, 4),
--('2014-07-01', '2018-07-01', 'Return to Cleveland Cavaliers', 81, 1, 4),
--('2018-07-01', '2021-07-01', 'Los Angeles Lakers', 82, 1, 4),
--('2021-07-01', '2023-12-31', 'Los Angeles Lakers (Late Career)', 83, 1, 3);

---- --------------------------------------------------------

----
---- Table structure for table `komandos`
----

--CREATE TABLE `komandos` (
--  `Pavadinimas` varchar(20) NOT NULL,
--  `Salis` varchar(20) NOT NULL,
--  `Miestas` varchar(20) NOT NULL,
--  `Ikurimo_data` date NOT NULL,
--  `id_Komanda` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `komandos`
----

--INSERT INTO `komandos` (`Pavadinimas`, `Salis`, `Miestas`, `Ikurimo_data`, `id_Komanda`) VALUES
--('Los Angeles Lakers', 'JAV', 'Los Angeles', '1947-01-01', 1),
--('CSKA Moscow', 'Rusija', 'Maskva', '1923-04-29', 2),
--('Fenerbahçe Beko', 'Turkija', 'Stambulas', '1913-04-03', 3),
--('Real Madrid Balonces', 'Ispanija', 'Madridas', '1931-03-08', 4),
--('Toronto Raptors', 'Kanada', 'Toronto', '1995-11-04', 5),
--('FC Barcelona Bàsquet', 'Ispanija', 'Barselona', '1926-03-24', 6),
--('Brooklyn Nets', 'JAV', 'Brooklyn', '1967-06-30', 7),
--('Anadolu Efes S.K.', 'Turkija', 'Stambulas', '1976-10-28', 8),
--('Houston Rockets', 'JAV', 'Houstonas', '1967-07-06', 9),
--('Olympiacos B.C.', 'Graikija', 'Pirėjai', '1937-03-10', 10),
--('Zalgiris Kaunas', 'Lithuania', 'Kaunas', '1944-09-16', 15),
--('Zalgiris Kaunas kaun', 'Ispanija', 'Kaunaselis', '0001-01-01', 18);

---- --------------------------------------------------------

----
---- Table structure for table `pareigos`
----

--CREATE TABLE `pareigos` (
--  `Pavadinimas` varchar(40) NOT NULL,
--  `id_Pareigos` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `pareigos`
----

--INSERT INTO `pareigos` (`Pavadinimas`, `id_Pareigos`) VALUES
--('Player', 1),
--('Assistant Coach', 2),
--('Head Coach', 3),
--('Academy Player', 4);

---- --------------------------------------------------------

----
---- Table structure for table `sekretoriatai`
----

--CREATE TABLE `sekretoriatai` (
--  `id_Sekretoriatas` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `sekretoriatai`
----

--INSERT INTO `sekretoriatai` (`id_Sekretoriatas`) VALUES
--(1),
--(2),
--(3),
--(4),
--(5),
--(6),
--(7),
--(8),
--(9),
--(10);

---- --------------------------------------------------------

----
---- Table structure for table `statistikos`
----

--CREATE TABLE `statistikos` (
--  `Dvitaskiu_pataikymas` float NOT NULL,
--  `Tritaskiu_pataikymas` float NOT NULL,
--  `Baudu_pataikymas` float NOT NULL,
--  `Vidutinis_tasku_skaicius` float NOT NULL,
--  `Laikas_aiksteleje` int(11) NOT NULL,
--  `EFF` int(11) NOT NULL,
--  `Vidutinis_baudu_skaicius` int(11) NOT NULL,
--  `id_Statistika` int(11) NOT NULL,
--  `fk_Zaidejasid_Zaidejas` int(11) NOT NULL,
--  `Sezonas` date NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `statistikos`
----

--INSERT INTO `statistikos` (`Dvitaskiu_pataikymas`, `Tritaskiu_pataikymas`, `Baudu_pataikymas`, `Vidutinis_tasku_skaicius`, `Laikas_aiksteleje`, `EFF`, `Vidutinis_baudu_skaicius`, `id_Statistika`, `fk_Zaidejasid_Zaidejas`, `Sezonas`) VALUES
--(0.45, 0.3, 0.7, 15.8, 25, 20, 4, 7, 53, '2023-01-01'),
--(0.5, 0.32, 0.75, 17.3, 26, 21, 5, 8, 53, '2023-01-01'),
--(0.42, 0.28, 0.68, 14.5, 24, 18, 3, 9, 54, '2023-01-01'),
--(0.47, 0.31, 0.72, 16.2, 25, 20, 4, 10, 54, '2023-01-01'),
--(0.53, 0.36, 0.77, 19.6, 28, 24, 5, 11, 55, '2023-01-01'),
--(0.49, 0.34, 0.74, 18.1, 27, 22, 4, 12, 55, '2023-01-01'),
--(0.56, 0.39, 0.8, 21.3, 30, 26, 6, 13, 56, '2023-01-01'),
--(0.54, 0.37, 0.78, 20.5, 29, 25, 5, 14, 56, '2023-01-01'),
--(0.55, 0.38, 0.79, 20.1, 28, 24, 5, 15, 57, '2023-01-01'),
--(0.51, 0.35, 0.76, 18.9, 27, 23, 4, 16, 57, '2023-01-01'),
--(0.47, 0.32, 0.73, 16.8, 25, 21, 4, 17, 58, '2023-01-01'),
--(0.48, 0.33, 0.74, 17.2, 26, 21, 4, 18, 59, '2023-01-01'),
--(0.52, 0.36, 0.77, 18.6, 27, 23, 5, 19, 60, '2023-01-01'),
--(0.45, 0.3, 0.7, 15.8, 25, 20, 4, 74, 61, '2018-01-01'),
--(0.5, 0.32, 0.75, 17.3, 26, 21, 5, 75, 61, '2018-01-01'),
--(0.42, 0.28, 0.68, 14.5, 24, 18, 3, 76, 62, '2019-01-01'),
--(0.47, 0.31, 0.72, 16.2, 25, 20, 4, 77, 62, '2019-01-01'),
--(0.53, 0.36, 0.77, 19.6, 28, 24, 5, 78, 63, '2020-01-01'),
--(0.49, 0.34, 0.74, 18.1, 27, 22, 4, 79, 63, '2020-01-01'),
--(0.56, 0.39, 0.8, 21.3, 30, 26, 6, 80, 64, '2021-01-01'),
--(0.54, 0.37, 0.78, 20.5, 29, 25, 5, 81, 64, '2021-01-01'),
--(0.55, 0.38, 0.79, 20.1, 28, 24, 5, 82, 65, '2022-01-01'),
--(0.51, 0.35, 0.76, 18.9, 27, 23, 4, 83, 65, '2022-01-01'),
--(0.47, 0.32, 0.73, 16.8, 25, 21, 4, 84, 66, '2023-01-01'),
--(0.48, 0.33, 0.74, 17.2, 26, 21, 4, 85, 67, '2024-01-01'),
--(0.52, 0.36, 0.77, 18.6, 27, 23, 5, 86, 68, '2025-01-01'),
--(0.45, 0.32, 0.7, 14.8, 24, 19, 4, 87, 66, '2022-01-01'),
--(0.48, 0.33, 0.73, 16.2, 25, 20, 5, 88, 66, '2022-01-01'),
--(0.42, 0.28, 0.68, 13.5, 23, 18, 3, 89, 67, '2023-01-01'),
--(0.47, 0.31, 0.72, 15.2, 24, 19, 4, 90, 67, '2023-01-01'),
--(0.4, 0.27, 0.65, 12.8, 22, 17, 3, 91, 68, '2024-01-01'),
--(0.45, 0.3, 0.7, 14.5, 23, 18, 4, 92, 68, '2024-01-01'),
--(0.38, 0.25, 0.63, 11.9, 21, 16, 3, 93, 69, '2025-01-01'),
--(0.42, 0.28, 0.68, 13.5, 22, 17, 4, 94, 69, '2025-01-01'),
--(0.36, 0.23, 0.6, 11.2, 20, 15, 3, 95, 70, '2026-01-01'),
--(0.4, 0.26, 0.65, 12.7, 21, 16, 4, 96, 70, '2026-01-01'),
--(0.34, 0.21, 0.58, 10.5, 19, 14, 3, 97, 71, '2027-01-01'),
--(0.38, 0.24, 0.63, 11.8, 20, 15, 4, 98, 71, '2027-01-01'),
--(0.32, 0.19, 0.55, 10, 18, 13, 3, 99, 72, '2028-01-01'),
--(0.36, 0.22, 0.6, 11.3, 19, 14, 4, 100, 72, '2028-01-01'),
--(0.47, 0.34, 0.72, 15.5, 26, 21, 5, 101, 73, '2022-01-01'),
--(0.45, 0.32, 0.7, 14.8, 25, 20, 4, 102, 73, '2022-01-01'),
--(0.45, 0.3, 0.68, 14, 24, 19, 4, 103, 74, '2021-01-01'),
--(0.43, 0.28, 0.66, 13.5, 23, 18, 3, 104, 74, '2021-01-01'),
--(0.43, 0.28, 0.65, 13.3, 23, 18, 4, 105, 75, '2020-01-01'),
--(0.41, 0.27, 0.63, 12.8, 22, 17, 3, 106, 75, '2020-01-01'),
--(0.41, 0.26, 0.63, 12.7, 22, 17, 4, 107, 76, '2019-01-01'),
--(0.39, 0.25, 0.61, 12.2, 21, 16, 3, 108, 76, '2019-01-01'),
--(0.39, 0.25, 0.61, 12.1, 21, 16, 4, 109, 77, '2018-01-01'),
--(0.37, 0.24, 0.59, 11.6, 20, 15, 3, 110, 77, '2018-01-01'),
--(0.37, 0.24, 0.59, 11.5, 20, 15, 4, 111, 78, '2017-01-01'),
--(0.35, 0.23, 0.57, 11, 19, 14, 3, 112, 78, '2017-01-01'),
--(0.35, 0.23, 0.57, 10.9, 19, 14, 4, 113, 79, '2016-01-01'),
--(0.33, 0.22, 0.55, 10.4, 18, 13, 3, 114, 79, '2016-01-01'),
--(0.47, 0.34, 0.72, 15.5, 26, 21, 5, 115, 80, '2022-01-01'),
--(0.45, 0.32, 0.7, 14.8, 25, 20, 4, 116, 80, '2022-01-01'),
--(0.45, 0.3, 0.68, 14, 24, 19, 4, 117, 81, '2021-01-01'),
--(0.43, 0.28, 0.66, 13.5, 23, 18, 3, 118, 81, '2021-01-01'),
--(0.43, 0.28, 0.65, 13.3, 23, 18, 4, 119, 82, '2020-01-01'),
--(0.41, 0.27, 0.63, 12.8, 22, 17, 3, 120, 82, '2020-01-01'),
--(0.41, 0.26, 0.63, 12.7, 22, 17, 4, 121, 83, '2019-01-01'),
--(0.39, 0.25, 0.61, 12.2, 21, 16, 3, 122, 83, '2019-01-01'),
--(0.39, 0.25, 0.61, 12.1, 21, 16, 4, 123, 84, '2018-01-01'),
--(0.37, 0.24, 0.59, 11.6, 20, 15, 3, 124, 84, '2018-01-01'),
--(0.37, 0.24, 0.59, 11.5, 20, 15, 4, 125, 85, '2017-01-01'),
--(0.35, 0.23, 0.57, 11, 19, 14, 3, 126, 85, '2017-01-01'),
--(0.35, 0.23, 0.57, 10.9, 19, 14, 4, 127, 86, '2016-01-01'),
--(0.33, 0.22, 0.55, 10.4, 18, 13, 3, 128, 86, '2016-01-01');

---- --------------------------------------------------------

----
---- Table structure for table `teisejai`
----

--CREATE TABLE `teisejai` (
--  `Vardas` varchar(20) NOT NULL,
--  `Pavarde` varchar(20) NOT NULL,
--  `Amzius` int(11) NOT NULL,
--  `Patirtis` int(11) NOT NULL,
--  `Tautybe` varchar(20) NOT NULL,
--  `id_Teisejas` int(11) NOT NULL,
--  `fk_Sekretoriatasid_Sekretoriatas` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `teisejai`
----

--INSERT INTO `teisejai` (`Vardas`, `Pavarde`, `Amzius`, `Patirtis`, `Tautybe`, `id_Teisejas`, `fk_Sekretoriatasid_Sekretoriatas`) VALUES
--('John', 'Smith', 45, 20, 'JAV', 1, 1),
--('Maria', 'Garcia', 40, 18, 'Ispanija', 2, 2),
--('Andrei', 'Ivanov', 50, 25, 'Rusija', 3, 3),
--('Sophie', 'Dupont', 38, 15, 'Prancūzija', 4, 4),
--('Mohammed', 'Ali', 42, 22, 'Egiptas', 5, 5),
--('Anna', 'Kowalski', 47, 19, 'Lenkija', 6, 6),
--('Luca', 'Bianchi', 43, 17, 'Italija', 7, 7),
--('Chen', 'Wei', 48, 21, 'Kinija', 8, 8),
--('Olga', 'Novak', 41, 16, 'Ukraina', 9, 9),
--('Ahmed', 'Said', 44, 23, 'Saudo Arabija', 10, 10),
--('Emma', 'Johnson', 39, 14, 'Kanada', 11, 1),
--('Alejandro', 'Martinez', 46, 20, 'Meksika', 12, 2),
--('Hans', 'Schmidt', 42, 18, 'Vokietija', 13, 3),
--('Elena', 'Gonzalez', 41, 16, 'Argentina', 14, 4),
--('Yusuke', 'Sato', 37, 12, 'Japonija', 15, 5),
--('Marta', 'Lopez', 45, 22, 'Brazilija', 16, 6),
--('Nikolai', 'Popov', 50, 25, 'Rusija', 17, 7),
--('Anna', 'Müller', 38, 15, 'Šveicarija', 18, 8),
--('Alessandro', 'Ricci', 43, 19, 'Italija', 19, 9),
--('Sofia', 'Kovalenko', 47, 21, 'Ukraina', 20, 10);

---- --------------------------------------------------------

----
---- Table structure for table `treneriai`
----

--CREATE TABLE `treneriai` (
--  `Vardas` varchar(20) NOT NULL,
--  `Pavardė` varchar(20) NOT NULL,
--  `Amžius` int(11) DEFAULT NULL,
--  `Tautybė` varchar(20) DEFAULT NULL,
--  `Patirtis` int(11) DEFAULT NULL,
--  `Pareigos` char(40) NOT NULL,
--  `id_Treneris` int(11) NOT NULL,
--  `fk_Komandaid_Komanda` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `treneriai`
----

--INSERT INTO `treneriai` (`Vardas`, `Pavardė`, `Amžius`, `Tautybė`, `Patirtis`, `Pareigos`, `id_Treneris`, `fk_Komandaid_Komanda`) VALUES
--('John', 'Smith', 55, 'JAV', 25, 'vyriausias_treneris', 1, 1),
--('Michael', 'Johnson', 42, 'JAV', 15, 'trenerio_asistentas', 2, 1),
--('David', 'Williams', 60, 'JAV', 30, 'trenerio_asistentas', 3, 1),
--('Sarah', 'Davis', 38, 'JAV', 10, 'trenerio_asistentas', 4, 1),
--('Ivan', 'Ivanov', 50, 'Rusija', 20, 'vyriausias_treneris', 5, 2),
--('Alexei', 'Smirnov', 45, 'Rusija', 15, 'trenerio_asistentas', 6, 2),
--('Elena', 'Kuznetsova', 48, 'Rusija', 18, 'trenerio_asistentas', 7, 2),
--('Dmitri', 'Petrov', 55, 'Rusija', 25, 'trenerio_asistentas', 8, 2),
--('Ahmet', 'Yılmaz', 48, 'Turkija', 22, 'vyriausias_treneris', 9, 3),
--('Mustafa', 'Demir', 40, 'Turkija', 12, 'trenerio_asistentas', 10, 3),
--('Ayşe', 'Kara', 43, 'Turkija', 15, 'trenerio_asistentas', 11, 3),
--('Ali', 'Çelik', 55, 'Turkija', 28, 'trenerio_asistentas', 12, 3),
--('José', 'García', 52, 'Ispanija', 18, 'vyriausias_treneris', 13, 4),
--('Antonio', 'Martínez', 47, 'Ispanija', 14, 'trenerio_asistentas', 14, 4),
--('María', 'López', 50, 'Ispanija', 20, 'trenerio_asistentas', 15, 4),
--('Carlos', 'Sánchez', 55, 'Ispanija', 25, 'trenerio_asistentas', 16, 4),
--('William', 'Brown', 45, 'Kanada', 18, 'vyriausias_treneris', 17, 5),
--('Emily', 'Taylor', 39, 'Kanada', 10, 'trenerio_asistentas', 18, 5),
--('Christopher', 'Clark', 50, 'JAV', 20, 'trenerio_asistentas', 19, 5),
--('Jessica', 'Lewis', 42, 'Kanada', 12, 'trenerio_asistentas', 20, 5),
--('Javier', 'Gómez', 48, 'Ispanija', 22, 'vyriausias_treneris', 21, 6),
--('Eduardo', 'Fernández', 43, 'Ispanija', 16, 'trenerio_asistentas', 22, 6),
--('Ana', 'Ruiz', 47, 'Ispanija', 19, 'trenerio_asistentas', 23, 6),
--('Pedro', 'Martínez', 55, 'Ispanija', 30, 'trenerio_asistentas', 24, 6),
--('Michael', 'Anderson', 50, 'JAV', 25, 'vyriausias_treneris', 25, 7),
--('Jessica', 'White', 38, 'JAV', 12, 'trenerio_asistentas', 26, 7),
--('Ryan', 'Thomas', 45, 'JAV', 18, 'trenerio_asistentas', 27, 7),
--('Emily', 'Scott', 42, 'JAV', 15, 'trenerio_asistentas', 28, 7),
--('Mehmet', 'Yıldırım', 48, 'Turkija', 22, 'vyriausias_treneris', 29, 8),
--('Fatma', 'Çetin', 40, 'Turkija', 12, 'trenerio_asistentas', 30, 8),
--('Cem', 'Arslan', 43, 'Turkija', 15, 'trenerio_asistentas', 31, 8),
--('Ayşe', 'Yılmaz', 55, 'Turkija', 28, 'trenerio_asistentas', 32, 8),
--('David', 'Miller', 50, 'JAV', 25, 'vyriausias_treneris', 33, 9),
--('Lisa', 'Wilson', 38, 'JAV', 12, 'trenerio_asistentas', 34, 9),
--('Matthew', 'Thompson', 45, 'JAV', 18, 'trenerio_asistentas', 35, 9),
--('Rachel', 'Adams', 42, 'JAV', 15, 'trenerio_asistentas', 36, 9),
--('Nikos', 'Papadopoulos', 52, 'Graikija', 18, 'vyriausias_treneris', 37, 10),
--('Maria', 'Georgiou', 47, 'Graikija', 14, 'trenerio_asistentas', 38, 10),
--('Yannis', 'Papandreou', 50, 'Graikija', 20, 'trenerio_asistentas', 39, 10),
--('Dimitra', 'Nikolaidis', 55, 'Graikija', 25, 'trenerio_asistentas', 40, 10),
--('Vardenis', 'Pavardenis', 0, 'world', 0, 'pareigbngas', 84, 4);

---- --------------------------------------------------------

----
---- Table structure for table `turnyrai`
----

--CREATE TABLE `turnyrai` (
--  `Salis` varchar(20) NOT NULL,
--  `Pavadinimas` varchar(20) NOT NULL,
--  `Komandu_skaicius` int(11) NOT NULL,
--  `Paskutinis_nugaletojas` varchar(20) DEFAULT NULL,
--  `Vadovas` varchar(40) NOT NULL,
--  `Ikurimo_data` date DEFAULT NULL,
--  `Varzybu_skaicius` int(11) NOT NULL,
--  `Metai` date NOT NULL,
--  `id_Turnyras` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `turnyrai`
----

--INSERT INTO `turnyrai` (`Salis`, `Pavadinimas`, `Komandu_skaicius`, `Paskutinis_nugaletojas`, `Vadovas`, `Ikurimo_data`, `Varzybu_skaicius`, `Metai`, `id_Turnyras`) VALUES
--('JAV', 'NBA Finals', 30, 'Los Angeles Lakers', 'Adam Silver', '1947-06-06', 4, '2023-06-01', 1),
--('Ispanija', 'EuroLeague Final Fou', 4, 'CSKA Moscow', 'Jordi Bertomeu', '1958-04-18', 10, '2023-05-01', 2),
--('Kinija', 'CBA Finals', 20, 'Beijing Ducks', 'Wang Dawei', '1995-11-01', 5, '2023-07-01', 3),
--('Turkija', 'TBL Finals', 18, 'Fenerbahçe Beko', 'Metin Sözen', '1966-10-01', 7, '2023-05-01', 4),
--('Prancūzija', 'LNB Pro A', 18, 'ASVEL Basket', 'Alain Béral', '1921-10-01', 5, '2023-05-01', 5);

---- --------------------------------------------------------

----
---- Table structure for table `turnyro_komandos`
----

--CREATE TABLE `turnyro_komandos` (
--  `id_Turnyro_komandos` int(11) NOT NULL,
--  `fk_Turnyrasid_Turnyras` int(11) NOT NULL,
--  `fk_Komandaid_Komanda` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `turnyro_komandos`
----

--INSERT INTO `turnyro_komandos` (`id_Turnyro_komandos`, `fk_Turnyrasid_Turnyras`, `fk_Komandaid_Komanda`) VALUES
--(1, 1, 1),
--(2, 2, 2),
--(3, 3, 3),
--(4, 4, 4),
--(5, 5, 5),
--(6, 1, 6),
--(7, 2, 7),
--(8, 3, 8),
--(9, 4, 9),
--(10, 5, 10),
--(11, 1, 1),
--(12, 2, 2),
--(13, 3, 3),
--(14, 4, 4),
--(15, 5, 5),
--(16, 1, 6),
--(17, 2, 7),
--(18, 3, 8),
--(19, 4, 9),
--(20, 5, 10),
--(21, 1, 1),
--(22, 2, 2),
--(23, 3, 3),
--(24, 4, 4),
--(25, 5, 5),
--(26, 1, 6),
--(27, 2, 7),
--(28, 3, 8),
--(29, 4, 9),
--(30, 5, 10);

---- --------------------------------------------------------

----
---- Table structure for table `varzybos`
----

--CREATE TABLE `varzybos` (
--  `Pradzia` date NOT NULL,
--  `Pabaiga` date NOT NULL,
--  `Rezultatas` varchar(7) NOT NULL,
--  `id_Varzybos` int(11) NOT NULL,
--  `Laimetojas` varchar(20) NOT NULL,
--  `fk_Komandaid_Komanda` int(11) NOT NULL,
--  `fk_Turnyrasid_Turnyras` int(11) NOT NULL,
--  `fk_Komandaid_Komanda1` int(11) NOT NULL,
--  `fk_Arenaid_Arena` int(11) NOT NULL,
--  `fk_Sekretoriatasid_Sekretoriatas` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `varzybos`
----

--INSERT INTO `varzybos` (`Pradzia`, `Pabaiga`, `Rezultatas`, `id_Varzybos`, `Laimetojas`, `fk_Komandaid_Komanda`, `fk_Turnyrasid_Turnyras`, `fk_Komandaid_Komanda1`, `fk_Arenaid_Arena`, `fk_Sekretoriatasid_Sekretoriatas`) VALUES
--('2023-10-15', '2023-10-15', '105:102', 1, 'Los Angeles Lakers', 1, 1, 2, 1, 1),
--('2023-10-17', '2023-10-17', '96:90', 2, 'CSKA Moscow', 2, 2, 1, 2, 2),
--('2023-10-20', '2023-10-20', '87:95', 3, 'Fenerbahçe Beko', 3, 3, 2, 3, 3),
--('2023-10-23', '2023-10-23', '102:100', 4, 'Real Madrid Balonces', 4, 4, 2, 4, 4),
--('2023-10-25', '2023-10-25', '118:120', 5, 'Toronto Raptors', 5, 5, 1, 5, 5),
--('2023-10-28', '2023-10-28', '98:101', 6, 'FC Barcelona Bàsquet', 6, 1, 3, 6, 6),
--('2023-10-31', '2023-10-31', '110:102', 7, 'Brooklyn Nets', 7, 2, 3, 7, 7),
--('2023-11-03', '2023-11-03', '88:86', 8, 'Anadolu Efes S.K.', 8, 3, 1, 8, 8),
--('2023-11-06', '2023-11-06', '109:112', 9, 'Houston Rockets', 9, 4, 5, 9, 9),
--('2023-11-09', '2023-11-09', '97:104', 10, 'Olympiacos B.C.', 10, 5, 2, 10, 10),
--('2023-11-12', '2023-11-12', '106:110', 11, 'CSKA Moscow', 2, 1, 4, 1, 1),
--('2023-11-15', '2023-11-15', '99:102', 12, 'Los Angeles Lakers', 1, 2, 3, 2, 2),
--('2023-11-18', '2023-11-18', '97:101', 13, 'Toronto Raptors', 5, 3, 4, 3, 3),
--('2023-11-21', '2023-11-21', '92:91', 14, 'Houston Rockets', 9, 4, 5, 4, 4),
--('2023-11-24', '2023-11-24', '110:104', 15, 'FC Barcelona Bàsquet', 6, 5, 1, 5, 5),
--('2023-11-27', '2023-11-27', '96:98', 16, 'Anadolu Efes S.K.', 8, 1, 2, 6, 6),
--('2023-11-26', '2023-11-26', '97:105', 17, 'CSKA Moscow', 2, 2, 3, 7, 1),
--('2023-11-29', '2023-11-29', '110:108', 18, 'Olympiacos B.C.', 10, 2, 6, 8, 10),
--('2023-12-02', '2023-12-02', '96:99', 19, 'Real Madrid Balonces', 4, 2, 1, 9, 4),
--('2023-12-05', '2023-12-05', '115:110', 20, 'Fenerbahçe Beko', 3, 2, 4, 10, 3),
--('2023-12-08', '2023-12-08', '112:105', 21, 'Toronto Raptors', 5, 2, 3, 1, 5),
--('2023-12-11', '2023-12-11', '97:102', 22, 'Brooklyn Nets', 7, 2, 2, 2, 8),
--('2023-12-14', '2023-12-14', '105:110', 23, 'Los Angeles Lakers', 1, 2, 4, 3, 1),
--('2023-12-17', '2023-12-17', '112:109', 24, 'Anadolu Efes S.K.', 8, 2, 5, 4, 7),
--('2023-12-20', '2023-12-20', '99:102', 25, 'FC Barcelona Bàsquet', 6, 2, 1, 5, 6),
--('2023-12-22', '2023-12-22', '102:108', 26, 'Houston Rockets', 9, 3, 4, 6, 9),
--('2023-12-25', '2023-12-25', '112:108', 27, 'Olympiacos B.C.', 10, 3, 1, 7, 10),
--('2023-12-28', '2023-12-28', '105:107', 28, 'Real Madrid Balonces', 4, 3, 2, 8, 4),
--('2023-12-31', '2023-12-31', '105:98', 29, 'Fenerbahçe Beko', 3, 3, 5, 9, 3),
--('2024-01-03', '2024-01-03', '98:101', 30, 'Toronto Raptors', 5, 3, 4, 10, 5),
--('2024-01-06', '2024-01-06', '115:108', 31, 'Los Angeles Lakers', 1, 4, 1, 1, 1),
--('2024-01-09', '2024-01-09', '112:107', 32, 'CSKA Moscow', 2, 4, 3, 2, 2),
--('2024-01-12', '2024-01-12', '105:103', 33, 'Anadolu Efes S.K.', 8, 4, 2, 3, 7),
--('2024-01-15', '2024-01-15', '109:112', 34, 'Brooklyn Nets', 7, 4, 1, 4, 8),
--('2024-01-18', '2024-01-18', '110:104', 35, 'Houston Rockets', 9, 4, 5, 9, 9),
--('2024-01-21', '2024-01-21', '105:98', 36, 'Olympiacos B.C.', 10, 5, 1, 1, 10),
--('2024-01-24', '2024-01-24', '105:103', 37, 'Real Madrid Balonces', 4, 5, 3, 2, 4),
--('2024-01-27', '2024-01-27', '110:104', 38, 'Fenerbahçe Beko', 3, 5, 1, 3, 3),
--('2024-01-30', '2024-01-30', '103:101', 39, 'Toronto Raptors', 5, 5, 2, 4, 5),
--('2024-02-02', '2024-02-02', '97:94', 40, 'Los Angeles Lakers', 1, 1, 3, 5, 1),
--('2024-02-05', '2024-02-05', '108:102', 41, 'CSKA Moscow', 2, 1, 2, 6, 2),
--('2024-02-08', '2024-02-08', '105:99', 42, 'Anadolu Efes S.K.', 8, 1, 5, 7, 7),
--('2024-02-11', '2024-02-11', '102:101', 43, 'Brooklyn Nets', 7, 1, 4, 8, 8),
--('2024-02-14', '2024-02-14', '106:104', 44, 'Houston Rockets', 9, 1, 2, 9, 9),
--('2024-02-17', '2024-02-17', '98:102', 45, 'Olympiacos B.C.', 10, 1, 5, 10, 10);

---- --------------------------------------------------------

----
---- Table structure for table `zaidejai`
----

--CREATE TABLE `zaidejai` (
--  `Vardas` varchar(20) NOT NULL,
--  `Pavarde` varchar(20) NOT NULL,
--  `Ugis` int(11) NOT NULL,
--  `Svoris` int(11) NOT NULL,
--  `Amzius` int(11) NOT NULL,
--  `Gimimo_vieta` varchar(20) DEFAULT NULL,
--  `Tautybe` varchar(20) NOT NULL,
--  `Pozicija` char(2) DEFAULT NULL,
--  `id_Zaidejas` int(11) NOT NULL,
--  `fk_Komandaid_Komanda` int(11) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

----
---- Dumping data for table `zaidejai`
----

--INSERT INTO `zaidejai` (`Vardas`, `Pavarde`, `Ugis`, `Svoris`, `Amzius`, `Gimimo_vieta`, `Tautybe`, `Pozicija`, `id_Zaidejas`, `fk_Komandaid_Komanda`) VALUES
--('LeBron', 'James', 203, 113, 37, 'Akronas', 'JAV', 'SF', 1, 1),
--('Anthony', 'Davis', 208, 115, 28, 'Kembrijus', 'JAV', 'PF', 2, 1),
--('Russell', 'Westbrook', 191, 91, 33, 'Long Beach', 'JAV', 'PG', 3, 1),
--('Carmelo', 'Anthony', 203, 109, 37, 'Nova Iorque', 'JAV', 'SF', 4, 1),
--('Dwight', 'Howard', 211, 120, 36, 'Atlanta', 'JAV', 'C', 5, 1),
--('Malik', 'Monk', 193, 90, 24, 'Jonesboro', 'JAV', 'SG', 6, 1),
--('Talen', 'Horton-Tucker', 196, 107, 21, 'Chicago', 'JAV', 'SG', 7, 1),
--('Wayne', 'Ellington', 193, 96, 34, 'Wynnewood', 'JAV', 'SG', 8, 1),
--('Kendrick', 'Nunn', 190, 95, 26, 'Chicago', 'JAV', 'PG', 9, 1),
--('DeAndre', 'Jordan', 211, 120, 33, 'Houstonas', 'JAV', 'C', 10, 1),
--('Trevor', 'Ariza', 203, 95, 36, 'Miami', 'JAV', 'SF', 11, 1),
--('Kent', 'Bazemore', 201, 93, 32, 'Kelford', 'JAV', 'SG', 12, 1),
--('Nikita', 'Kurbanov', 202, 105, 35, 'Perm', 'Rusija', 'SF', 13, 2),
--('Mike', 'James', 188, 88, 31, 'Portland', 'JAV', 'PG', 14, 2),
--('Will', 'Clyburn', 201, 100, 31, 'Detroit', 'JAV', 'SF', 15, 2),
--('Darrun', 'Hilliard', 201, 99, 28, 'Bethlehem', 'JAV', 'SG', 16, 2),
--('Daniel', 'Hackett', 197, 97, 34, 'Bolcano', 'JAV', 'PG', 17, 2),
--('Tornike', 'Shengelia', 206, 107, 30, 'Tbilisi', 'Gruzija', 'PF', 18, 2),
--('Joel', 'Bolomboy', 206, 113, 27, 'Fort Worth', 'JAV', 'C', 19, 2),
--('Nikola', 'Milutinov', 215, 124, 27, 'Nikšić', 'Juodkalnija', 'C', 20, 2),
--('Nikola', 'Ivanović', 193, 92, 29, 'Kraljevo', 'Serbija', 'SG', 21, 2),
--('Iffe', 'Lundberg', 193, 89, 27, 'Holstebro', 'Danija', 'SG', 22, 2),
--('Nikos', 'Zisis', 195, 92, 38, 'Thessaloniki', 'Graikija', 'PG', 23, 2),
--('Sergio', 'Rodríguez', 191, 86, 35, 'San Cristóbal de La ', 'Ispanija', 'PG', 24, 2),
--('Nando', 'De Colo', 196, 91, 34, 'Sainte-Catherine-lès', 'Prancūzija', 'SG', 25, 3),
--('Jan', 'Veselý', 213, 113, 31, 'České Budějovice', 'Čekija', 'C', 26, 3),
--('Alex', 'Akcje', 193, 92, 27, 'Niort', 'Prancūzija', 'SG', 27, 3),
--('Dyshawn', 'Pierre', 198, 98, 28, 'Whitby', 'Kanada', 'SF', 28, 3),
--('Kostas', 'Sloukas', 197, 96, 31, 'Athens', 'Graikija', 'PG', 29, 3),
--('Edgaras', 'Ulanovas', 197, 98, 29, 'Klaipėda', 'Lietuva', 'SF', 30, 3),
--('Berkay', 'Candan', 203, 95, 23, 'Ankara', 'Turkija', 'SF', 31, 3),
--('Ahmet', 'Düverioğlu', 212, 120, 28, 'İstanbul', 'Turkija', 'C', 32, 3),
--('Kenan', 'Sipahi', 196, 92, 25, 'İstanbul', 'Turkija', 'PG', 33, 3),
--('Bobby', 'Dixon', 178, 78, 35, 'Chicago', 'JAV', 'PG', 34, 3),
--('Denzel', 'Dykstra', 206, 107, 25, 'Poughkeepsie', 'JAV', 'PF', 35, 3),
--('Semih', 'Erden', 211, 113, 35, 'Istanbulas', 'Turkija', 'C', 36, 3),
--('Walter', 'Tavares', 221, 132, 29, 'Praia', 'Zaliasis Kyšulys', 'C', 37, 4),
--('Gabriel', 'Deck', 201, 102, 26, 'Villa María', 'Argentina', 'SF', 38, 4),
--('Alberto', 'Abalde', 201, 98, 26, 'A Coruña', 'Ispanija', 'SF', 39, 4),
--('Trey', 'Thompkins', 208, 107, 31, 'Long Beach', 'JAV', 'PF', 40, 4),
--('Nigel', 'Williams-Goss', 190, 95, 27, 'Happy Valley', 'JAV', 'PG', 41, 4),
--('Sergio', 'Llull', 190, 89, 34, 'Mahón', 'Ispanija', 'SG', 42, 4),
--('Jaycee', 'Carroll', 188, 86, 38, 'Laramie', 'JAV', 'SG', 43, 4),
--('Carlos', 'Alocén', 197, 89, 21, 'Zaragoza', 'Ispanija', 'PG', 44, 4),
--('Usman', 'Garuba', 203, 100, 20, 'Madridas', 'Ispanija', 'PF', 45, 4),
--('Felipe', 'Reyes', 206, 116, 41, 'Córdoba', 'Ispanija', 'PF', 46, 4),
--('Gustavo', 'Ayón', 208, 114, 36, 'Tijuana', 'Meksika', 'C', 47, 4),
--('Jeffery', 'Taylor', 201, 102, 32, 'Norrköping', 'Švedija', 'SF', 48, 4),
--('Pascal', 'Siakam', 206, 109, 28, 'Douala', 'Kamerūnas', 'PF', 49, 5),
--('Fred', 'VanVleet', 183, 88, 27, 'Rockford', 'JAV', 'PG', 50, 5),
--('OG', 'Anunoby', 203, 104, 24, 'Londone', 'DNR', 'SF', 51, 5),
--('Gary', 'Trent Jr.', 196, 97, 23, 'Columbus', 'JAV', 'SG', 52, 5),
--('Goran', 'Dragić', 190, 86, 35, 'Ljubljana', 'Slovėnija', 'PG', 53, 5),
--('Chris', 'Boucher', 208, 200, 28, 'Castries', 'Sent Lusija', 'PF', 54, 5),
--('Scottie', 'Barnes', 203, 99, 20, 'West Palm Beach', 'JAV', 'SF', 55, 5),
--('Khem', 'Birch', 206, 102, 29, 'Montréal', 'Kanada', 'C', 56, 5),
--('Aron', 'Baynes', 208, 118, 35, 'Gisborne', 'Naujoji Zelandija', 'C', 57, 5),
--('Malachi', 'Flynn', 185, 85, 23, 'Tacoma', 'JAV', 'PG', 58, 5),
--('Precious', 'Achiuwa', 208, 100, 22, 'Port Harcourt', 'Nigerija', 'PF', 59, 5),
--('Dalano', 'Banton', 201, 95, 22, 'Toronto', 'Kanada', 'SG', 60, 5),
--('Nikola', 'Mirotić', 208, 113, 31, 'Podgorica', 'Juodkalnija', 'PF', 61, 6),
--('Alex', 'Abrines', 198, 93, 28, 'Palma de Mallorca', 'Ispanija', 'SG', 62, 6),
--('Brandon', 'Davies', 208, 109, 30, 'Philadelphia', 'JAV', 'C', 63, 6),
--('Adam', 'Hanga', 202, 99, 32, 'Budapeštas', 'Vengrija', 'SF', 64, 6),
--('Leandro', 'Bolmaro', 201, 93, 21, 'Las Varillas', 'Argentina', 'SG', 65, 6),
--('Cory', 'Higgins', 196, 99, 32, 'Danville', 'JAV', 'SG', 66, 6),
--('Nick', 'Calathes', 198, 97, 33, 'Casselberry', 'JAV', 'PG', 67, 6),
--('Rolands', 'Smits', 213, 112, 26, 'Riga', 'Latvija', 'PF', 68, 6),
--('Kyle', 'Kuric', 193, 91, 31, 'Evansville', 'JAV', 'SG', 69, 6),
--('Sergi', 'Martínez', 206, 102, 23, 'Barcelona', 'Ispanija', 'PF', 70, 6),
--('Víctor', 'Claver', 208, 102, 33, 'Valencia', 'Ispanija', 'PF', 71, 6),
--('Thomas', 'Heurtel', 189, 80, 32, 'Bezons', 'Prancūzija', 'PG', 72, 6),
--('Kevin', 'Durant', 206, 109, 33, 'Washington, D.C.', 'JAV', 'SF', 73, 7),
--('Kyrie', 'Irving', 193, 88, 29, 'Melburnas', 'Australija', 'PG', 74, 7),
--('James', 'Harden', 196, 100, 32, 'Los Angeles', 'JAV', 'SG', 75, 7),
--('Joe', 'Harris', 198, 99, 30, 'Chelan', 'JAV', 'SG', 76, 7),
--('LaMarcus', 'Aldridge', 211, 117, 36, 'Dallas', 'JAV', 'C', 77, 7),
--('Blake', 'Griffin', 208, 113, 33, 'Oklahoma City', 'JAV', 'PF', 78, 7),
--('DeAndre', 'Bembry', 201, 99, 27, 'Charlotte', 'JAV', 'SF', 79, 7),
--('Patty', 'Mills', 183, 84, 33, 'Canberra', 'Australija', 'PG', 80, 7),
--('Bruce', 'Brown', 198, 98, 25, 'Boston', 'JAV', 'SG', 81, 7),
--('Nicolas', 'Claxton', 211, 99, 22, 'Greenville', 'JAV', 'C', 82, 7),
--('Paul', 'Millsap', 203, 113, 37, 'Monroe', 'JAV', 'PF', 83, 7),
--('Sekou', 'Doumbouya', 206, 99, 21, 'Conakry', 'Gvinėja', 'PF', 84, 7),
--('Vasilije', 'Micić', 196, 91, 27, 'Belgradas', 'Serbija', 'PG', 85, 8),
--('Shane', 'Larkin', 182, 80, 29, 'Cincinnati', 'JAV', 'PG', 86, 8),
--('Chris', 'Singleton', 206, 104, 32, 'Los Angeles', 'JAV', 'SF', 87, 8),
--('Adrien', 'Moerman', 203, 104, 32, 'Fontenay-aux-Roses', 'Prancūzija', 'PF', 88, 8),
--('Rodrigue', 'Beaubois', 190, 87, 33, 'Pointe-à-Pitre', 'Prancūzijos Gvadelup', 'SG', 89, 8),
--('Sertac', 'Şanlı', 208, 108, 30, 'Aliağa', 'Turkija', 'C', 90, 8),
--('Bryant', 'Dunston', 203, 104, 36, 'Forsyth', 'JAV', 'PF', 91, 8),
--('Krunoslav', 'Simon', 202, 104, 36, 'Zagreb', 'Kroatija', 'SF', 92, 8),
--('Chris', 'Singleton', 206, 104, 32, 'Los Angeles', 'JAV', 'PF', 93, 8),
--('Yiğitcan', 'Saybir', 196, 91, 22, 'Istanbul', 'Turkija', 'SG', 94, 8),
--('Tibor', 'Pleiss', 221, 118, 32, 'Bergisch Gladbach', 'Vokietija', 'C', 95, 8),
--('Dzanan', 'Mus', 206, 104, 22, 'Bosanska Gradiška', 'Bosnija ir Hercegovi', 'SF', 96, 8),
--('Christian', 'Wood', 211, 109, 26, 'Long Beach', 'JAV', 'PF', 97, 9),
--('Jalen', 'Green', 196, 86, 20, 'Fresno', 'JAV', 'SG', 98, 9),
--('Kevin', 'Porter Jr.', 198, 93, 21, 'Seattle', 'JAV', 'PG', 99, 9),
--('John', 'Wall', 193, 88, 31, 'Raleigh', 'JAV', 'PG', 100, 9),
--('Daniel', 'Theis', 206, 111, 30, 'Salzgitter', 'Vokietija', 'C', 101, 9),
--('Eric', 'Gordon', 193, 98, 33, 'Indianapolis', 'JAV', 'SG', 102, 9),
--('Armoni', 'Brooks', 193, 86, 23, 'Concord', 'JAV', 'SG', 103, 9),
--('David', 'Nwaba', 193, 98, 29, 'Los Angeles', 'JAV', 'SG', 104, 9),
--('Kenyon', 'Martin Jr.', 201, 99, 21, 'Waukegan', 'JAV', 'SF', 105, 9),
--('D.J.', 'Augustin', 183, 80, 34, 'New Orleans', 'JAV', 'PG', 106, 9),
--('Khyri', 'Thomas', 196, 95, 25, 'Omaha', 'JAV', 'SG', 107, 9),
--('Usman', 'Garuba', 203, 100, 20, 'Madrid', 'Ispanija', 'PF', 108, 9),
--('Kostas', 'Papanikolaou', 206, 102, 30, 'Πατρα', 'Graikija', 'SF', 109, 10),
--('Vassilis', 'Spanoulis', 193, 95, 39, 'Larisa', 'Graikija', 'PG', 110, 10),
--('Georgios', 'Printezis', 206, 110, 36, 'Athens', 'Graikija', 'PF', 111, 10),
--('Kostas', 'Sloukas', 197, 96, 32, 'Thessaloniki', 'Graikija', 'PG', 112, 10),
--('Aaron', 'Harrison', 198, 95, 27, 'San Antonio', 'JAV', 'SG', 113, 10),
--('Hassan', 'Martin', 206, 104, 27, 'Staten Island', 'JAV', 'PF', 114, 10),
--('Zach', 'LeDay', 201, 102, 27, 'Dallas', 'JAV', 'PF', 115, 10),
--('Kostas', 'Antetokounmpo', 211, 100, 24, 'Atenas', 'Graikija', 'PF', 116, 10),
--('Livio', 'Jean-Charles', 206, 102, 27, 'Cayenne', 'Prancūzijos Gvadelup', 'PF', 117, 10),
--('Vincent', 'Poirier', 213, 109, 28, 'Clamart', 'Prancūzija', 'C', 118, 10),
--('Kostas', 'Sloukas', 197, 96, 32, 'Thessaloniki', 'Graikija', 'PG', 119, 10),
--('Alec', 'Peters', 206, 105, 26, 'Washington', 'JAV', 'PF', 120, 10),
--('Keenan', 'Evans', 198, 92, 31, 'Winsonsin', 'American', 'PG', 122, 15);

----
---- Indexes for dumped tables
----

----
---- Indexes for table `arenos`
----
--ALTER TABLE `arenos`
--  ADD PRIMARY KEY (`id_Arena`);

----
---- Indexes for table `darbuotojai`
----
--ALTER TABLE `darbuotojai`
--  ADD PRIMARY KEY (`id_Darbuotojas`),
--  ADD KEY `dirba_1` (`fk_Sekretoriatasid_Sekretoriatas`);

----
---- Indexes for table `karjeros_etapai`
----
--ALTER TABLE `karjeros_etapai`
--  ADD PRIMARY KEY (`id_Karjeros_etapas`),
--  ADD KEY `turi_1` (`fk_Zaidejasid_Zaidejas`);

----
---- Indexes for table `komandos`
----
--ALTER TABLE `komandos`
--  ADD PRIMARY KEY (`id_Komanda`);

----
---- Indexes for table `pareigos`
----
--ALTER TABLE `pareigos`
--  ADD PRIMARY KEY (`id_Pareigos`);

----
---- Indexes for table `sekretoriatai`
----
--ALTER TABLE `sekretoriatai`
--  ADD PRIMARY KEY (`id_Sekretoriatas`);

----
---- Indexes for table `statistikos`
----
--ALTER TABLE `statistikos`
--  ADD PRIMARY KEY (`id_Statistika`),
--  ADD KEY `turi_2` (`fk_Zaidejasid_Zaidejas`);

----
---- Indexes for table `teisejai`
----
--ALTER TABLE `teisejai`
--  ADD PRIMARY KEY (`id_Teisejas`),
--  ADD KEY `dirba_2` (`fk_Sekretoriatasid_Sekretoriatas`);

----
---- Indexes for table `treneriai`
----
--ALTER TABLE `treneriai`
--  ADD PRIMARY KEY (`id_Treneris`);

----
---- Indexes for table `turnyrai`
----
--ALTER TABLE `turnyrai`
--  ADD PRIMARY KEY (`id_Turnyras`);

----
---- Indexes for table `turnyro_komandos`
----
--ALTER TABLE `turnyro_komandos`
--  ADD PRIMARY KEY (`id_Turnyro_komandos`),
--  ADD KEY `dalyvauja` (`fk_Turnyrasid_Turnyras`),
--  ADD KEY `sudaro` (`fk_Komandaid_Komanda`);

----
---- Indexes for table `varzybos`
----
--ALTER TABLE `varzybos`
--  ADD PRIMARY KEY (`id_Varzybos`),
--  ADD KEY `zaidzia_1` (`fk_Komandaid_Komanda`),
--  ADD KEY `vyksta` (`fk_Turnyrasid_Turnyras`),
--  ADD KEY `zaidzia_2` (`fk_Komandaid_Komanda1`),
--  ADD KEY `suteikia_vieta` (`fk_Arenaid_Arena`),
--  ADD KEY `priziuri` (`fk_Sekretoriatasid_Sekretoriatas`);

----
---- Indexes for table `zaidejai`
----
--ALTER TABLE `zaidejai`
--  ADD PRIMARY KEY (`id_Zaidejas`),
--  ADD KEY `zaidzia_uz` (`fk_Komandaid_Komanda`);

----
---- AUTO_INCREMENT for dumped tables
----

----
---- AUTO_INCREMENT for table `arenos`
----
--ALTER TABLE `arenos`
--  MODIFY `id_Arena` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

----
---- AUTO_INCREMENT for table `darbuotojai`
----
--ALTER TABLE `darbuotojai`
--  MODIFY `id_Darbuotojas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

----
---- AUTO_INCREMENT for table `karjeros_etapai`
----
--ALTER TABLE `karjeros_etapai`
--  MODIFY `id_Karjeros_etapas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=86;

----
---- AUTO_INCREMENT for table `komandos`
----
--ALTER TABLE `komandos`
--  MODIFY `id_Komanda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

----
---- AUTO_INCREMENT for table `pareigos`
----
--ALTER TABLE `pareigos`
--  MODIFY `id_Pareigos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

----
---- AUTO_INCREMENT for table `sekretoriatai`
----
--ALTER TABLE `sekretoriatai`
--  MODIFY `id_Sekretoriatas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

----
---- AUTO_INCREMENT for table `statistikos`
----
--ALTER TABLE `statistikos`
--  MODIFY `id_Statistika` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=129;

----
---- AUTO_INCREMENT for table `teisejai`
----
--ALTER TABLE `teisejai`
--  MODIFY `id_Teisejas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

----
---- AUTO_INCREMENT for table `treneriai`
----
--ALTER TABLE `treneriai`
--  MODIFY `id_Treneris` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=85;

----
---- AUTO_INCREMENT for table `turnyrai`
----
--ALTER TABLE `turnyrai`
--  MODIFY `id_Turnyras` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

----
---- AUTO_INCREMENT for table `turnyro_komandos`
----
--ALTER TABLE `turnyro_komandos`
--  MODIFY `id_Turnyro_komandos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

----
---- AUTO_INCREMENT for table `zaidejai`
----
--ALTER TABLE `zaidejai`
--  MODIFY `id_Zaidejas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=124;

----
---- Constraints for dumped tables
----

----
---- Constraints for table `darbuotojai`
----
--ALTER TABLE `darbuotojai`
--  ADD CONSTRAINT `dirba_1` FOREIGN KEY (`fk_Sekretoriatasid_Sekretoriatas`) REFERENCES `sekretoriatai` (`id_Sekretoriatas`);

----
---- Constraints for table `karjeros_etapai`
----
--ALTER TABLE `karjeros_etapai`
--  ADD CONSTRAINT `turi_1` FOREIGN KEY (`fk_Zaidejasid_Zaidejas`) REFERENCES `zaidejai` (`id_Zaidejas`);

----
---- Constraints for table `statistikos`
----
--ALTER TABLE `statistikos`
--  ADD CONSTRAINT `turi_2` FOREIGN KEY (`fk_Zaidejasid_Zaidejas`) REFERENCES `zaidejai` (`id_Zaidejas`);

----
---- Constraints for table `teisejai`
----
--ALTER TABLE `teisejai`
--  ADD CONSTRAINT `dirba_2` FOREIGN KEY (`fk_Sekretoriatasid_Sekretoriatas`) REFERENCES `sekretoriatai` (`id_Sekretoriatas`);

----
---- Constraints for table `turnyro_komandos`
----
--ALTER TABLE `turnyro_komandos`
--  ADD CONSTRAINT `dalyvauja` FOREIGN KEY (`fk_Turnyrasid_Turnyras`) REFERENCES `turnyrai` (`id_Turnyras`),
--  ADD CONSTRAINT `sudaro` FOREIGN KEY (`fk_Komandaid_Komanda`) REFERENCES `komandos` (`id_Komanda`);

----
---- Constraints for table `varzybos`
----
--ALTER TABLE `varzybos`
--  ADD CONSTRAINT `priziuri` FOREIGN KEY (`fk_Sekretoriatasid_Sekretoriatas`) REFERENCES `sekretoriatai` (`id_Sekretoriatas`),
--  ADD CONSTRAINT `suteikia_vieta` FOREIGN KEY (`fk_Arenaid_Arena`) REFERENCES `arenos` (`id_Arena`),
--  ADD CONSTRAINT `vyksta` FOREIGN KEY (`fk_Turnyrasid_Turnyras`) REFERENCES `turnyrai` (`id_Turnyras`),
--  ADD CONSTRAINT `zaidzia_1` FOREIGN KEY (`fk_Komandaid_Komanda`) REFERENCES `komandos` (`id_Komanda`),
--  ADD CONSTRAINT `zaidzia_2` FOREIGN KEY (`fk_Komandaid_Komanda1`) REFERENCES `komandos` (`id_Komanda`);

----
---- Constraints for table `zaidejai`
----
--ALTER TABLE `zaidejai`
--  ADD CONSTRAINT `zaidzia_uz` FOREIGN KEY (`fk_Komandaid_Komanda`) REFERENCES `komandos` (`id_Komanda`);
--COMMIT;

--/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
--/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
--/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
