-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Nov 25. 17:55
-- Kiszolgáló verziója: 10.4.27-MariaDB
-- PHP verzió: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `ingatlanok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `felhasznalok`
--

CREATE TABLE `felhasznalok` (
  `adojel` bigint(10) NOT NULL,
  `jelszo` varchar(255) NOT NULL,
  `nev` varchar(255) NOT NULL,
  `lakcim` varchar(255) NOT NULL,
  `telefonszam` bigint(20) NOT NULL,
  `szuletesi datum` date NOT NULL,
  `anyja neve` varchar(255) NOT NULL,
  `be van-e jelentkezve` tinyint(1) NOT NULL,
  `utolso belepes` datetime NOT NULL,
  `szerepkor` tinyint(3) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `felhasznalok`
--

INSERT INTO `felhasznalok` (`adojel`, `jelszo`, `nev`, `lakcim`, `telefonszam`, `szuletesi datum`, `anyja neve`, `be van-e jelentkezve`, `utolso belepes`, `szerepkor`) VALUES
(123456789, '$2a$10$mPrmD1n4G3RGR/9qMOUQFehU20ZJmp92sD344SUw4i8pJ/7j6NEiW', 'Gipsz Jakab', 'Szeged, Retek utca 6', 636301231234, '1994-01-04', 'Lakatos Ilona', 0, '2023-11-24 22:34:30', 0),
(1111111111, '$2a$10$rtmCBnZSGK3VGl5cFDZ.HuPt6/wYbOu.qzyrQ129D/8RfZG.r3sb6', 'Admin Bácsi', 'Szeged, Belvárosi híd alatt', 0, '2000-12-24', '', 0, '2023-11-25 16:26:58', 1),
(1111234567, '$2a$10$lYTWzhjrJ5SkgOie9qhlBegLENrmS9EgJ9aTjJ8ThgxNTD3SBj7X2', 'Teszt Elek', 'Szeghalom, Kör utca 6', 636703331234, '1974-05-20', 'Szűcs Mária', 0, '2023-11-24 22:28:15', 0),
(1112345678, '$2a$10$QKcC.UnxWRbY/3hCoftbI.Jjj2JemuYMv5kYLygb/k3uKTDnPDdii', 'Laci (A vállalkozó)', 'Jászladány, Szegfűszeg utca 22', 636307557884, '1980-03-15', 'Jász Cili (Ne sírj, megváltozom)', 0, '2023-11-24 22:48:18', 0),
(1123456789, '$2a$10$LVho/4KHnPBqqbCl5gB7suDp4iPsA2YBo5XBMM7gUSiIkBJIsFnwm', 'Lakatos Brendon', 'Szeged, Boldogasszony sugárút 35', 636304223876, '1980-03-11', 'Bognár Andrea', 0, '2023-11-24 22:45:52', 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ingatlan jellegek`
--

CREATE TABLE `ingatlan jellegek` (
  `azonosito` int(11) NOT NULL,
  `nev` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ingatlan jellegek`
--

INSERT INTO `ingatlan jellegek` (`azonosito`, `nev`) VALUES
(1, 'Egyéb'),
(2, 'Ipari épület'),
(3, 'Lakóépület'),
(5, 'Ismeretlen');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ingatlanok`
--

CREATE TABLE `ingatlanok` (
  `azonosito` int(11) NOT NULL,
  `telek azonosito` int(11) NOT NULL,
  `jelleg` int(11) NOT NULL,
  `epites eve` int(11) NOT NULL,
  `kozterulet` varchar(255) NOT NULL,
  `hazszam` varchar(255) NOT NULL,
  `becsult ertek` bigint(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ingatlanok`
--

INSERT INTO `ingatlanok` (`azonosito`, `telek azonosito`, `jelleg`, `epites eve`, `kozterulet`, `hazszam`, `becsult ertek`) VALUES
(3, 1, 1, 1980, 'Püspök utca', '1', 14000000),
(5, 1, 2, 1980, 'Püspök utca', '3', 13000000),
(6, 1, 2, 1920, 'Kossuth Lajos sugárút', '4', 23000000),
(8, 1, 3, 1980, 'Kossuth Lajos sugárút', '6', 17000000),
(9, 19, 3, 2000, 'Almafa utca', '10', 30000000),
(11, 19, 2, 2000, 'Almafa utca', '11', 4000000),
(16, 2, 3, 1998, 'Gutenberg utca', '10', 40000000),
(17, 2, 3, 1998, 'Gutenberg utca', '9', 42000000),
(18, 3, 2, 1984, 'Londoni körút', '22', 30000000),
(19, 4, 2, 1983, 'Kálvária sugárút', '29', 36000000),
(20, 4, 3, 1983, 'Londoni körút', '32', 51000000),
(21, 5, 2, 1995, 'Vitéz utca', '24', 40000000),
(22, 6, 2, 1992, 'Vitéz utca', '24', 32000000),
(23, 7, 2, 1989, 'Vitéz utca', '28', 100000000),
(24, 8, 1, 1974, 'Egyetem utca', '2', 81000000),
(25, 9, 2, 1995, 'Szentháromság utca', '6', 35000000),
(26, 10, 1, 1998, 'Vitéz utca', '1', 50000000),
(27, 10, 1, 1998, 'Boldogasszony sugárút', '9', 25000000),
(28, 12, 1, 1886, 'Tisza Lajos körút', '103', 89000000),
(29, 13, 1, 1894, 'Aradi vértanúk tere', '1', 143000000),
(30, 14, 3, 1987, 'Tisza Lajos körút', '76', 45000000),
(31, 15, 1, 1978, 'Dugonics tér', '11', 75000000),
(32, 16, 1, 1972, 'Oskola utca', '3', 34000000),
(33, 17, 3, 1988, 'Deák Ferenc utca', '26', 34000000),
(34, 17, 3, 1988, 'Deák Ferenc utca', '24', 34000000);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ingatlan tulajdonosok`
--

CREATE TABLE `ingatlan tulajdonosok` (
  `ingatlan azonosito` int(11) NOT NULL,
  `tulajdonos adojel` bigint(20) NOT NULL,
  `tulajdonba kerules datuma` date NOT NULL,
  `tulajdonhanyad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ingatlan tulajdonosok`
--

INSERT INTO `ingatlan tulajdonosok` (`ingatlan azonosito`, `tulajdonos adojel`, `tulajdonba kerules datuma`, `tulajdonhanyad`) VALUES
(9, 1123456789, '2023-11-19', 100),
(11, 1123456789, '2023-11-24', 50),
(11, 1111111111, '2023-11-24', 50),
(3, 1111234567, '2023-11-25', 25),
(3, 1112345678, '2023-11-25', 50),
(5, 1112345678, '2023-11-25', 90),
(6, 1111234567, '2023-11-25', 10),
(6, 1112345678, '2023-11-25', 90),
(8, 1111234567, '2023-11-25', 100),
(16, 1112345678, '2023-11-25', 90),
(16, 123456789, '2023-11-25', 10),
(17, 123456789, '2023-11-25', 100),
(18, 1111234567, '2023-11-25', 100),
(19, 1112345678, '2023-11-25', 100),
(20, 1111234567, '2023-11-25', 20),
(20, 123456789, '2023-11-25', 80),
(21, 1111234567, '2023-11-25', 100),
(22, 1111234567, '2023-11-25', 90),
(22, 1123456789, '2023-11-25', 10),
(23, 123456789, '2023-11-25', 100),
(24, 1112345678, '2023-11-25', 90),
(24, 1111234567, '2023-11-25', 10),
(25, 1112345678, '2023-11-25', 80),
(25, 1111234567, '2023-11-25', 10),
(25, 1123456789, '2023-11-25', 10),
(26, 1123456789, '2023-11-25', 100),
(27, 1123456789, '2023-11-25', 20),
(27, 1111234567, '2023-11-25', 80),
(28, 1111234567, '2023-11-25', 100),
(29, 123456789, '2023-11-25', 60),
(29, 1112345678, '2023-11-25', 20),
(29, 1123456789, '2023-11-25', 20),
(30, 1112345678, '2023-11-25', 100),
(32, 1112345678, '2023-11-25', 100),
(33, 123456789, '2023-11-25', 80),
(33, 1111234567, '2023-11-25', 20),
(34, 123456789, '2023-11-25', 60),
(34, 1112345678, '2023-11-25', 40),
(5, 1111234567, '2023-11-25', 10),
(3, 123456789, '2023-11-25', 25);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `telek jellegek`
--

CREATE TABLE `telek jellegek` (
  `azonosito` int(11) NOT NULL,
  `nev` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `telek jellegek`
--

INSERT INTO `telek jellegek` (`azonosito`, `nev`) VALUES
(1, 'Ismeretlen'),
(2, 'Lakóövezeti'),
(3, 'Üdülőövezeti'),
(4, 'Külterületi'),
(5, 'Építési');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `telek tulajdonosok`
--

CREATE TABLE `telek tulajdonosok` (
  `telek azonosito` int(11) NOT NULL,
  `tulajdonos adojel` bigint(20) NOT NULL,
  `tulajdonba kerules datuma` date NOT NULL,
  `tulajdonhanyad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `telek tulajdonosok`
--

INSERT INTO `telek tulajdonosok` (`telek azonosito`, `tulajdonos adojel`, `tulajdonba kerules datuma`, `tulajdonhanyad`) VALUES
(19, 1123456789, '2023-11-18', 75),
(19, 123456789, '2023-11-19', 25),
(1, 1111234567, '2023-11-25', 25),
(1, 1112345678, '2023-11-25', 75),
(2, 1112345678, '2023-11-25', 100),
(3, 1112345678, '2023-11-25', 70),
(3, 1111234567, '2023-11-25', 30),
(4, 1112345678, '2023-11-25', 100),
(6, 1111234567, '2023-11-25', 100),
(7, 123456789, '2023-11-25', 100),
(8, 1112345678, '2023-11-25', 100),
(9, 1112345678, '2023-11-25', 100),
(10, 1123456789, '2023-11-25', 10),
(10, 1111234567, '2023-11-25', 90),
(12, 1111234567, '2023-11-25', 100),
(13, 123456789, '2023-11-25', 100),
(14, 1112345678, '2023-11-25', 100),
(15, 1111234567, '2023-11-25', 30),
(15, 1123456789, '2023-11-25', 70),
(16, 1112345678, '2023-11-25', 100),
(17, 123456789, '2023-11-25', 100),
(5, 1111234567, '2023-11-25', 100),
(22, 1123456789, '2023-11-25', 100);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `telkek`
--

CREATE TABLE `telkek` (
  `azonosito` int(11) NOT NULL,
  `helyrajzi szam` int(11) NOT NULL,
  `jelleg` int(11) NOT NULL,
  `iranyitoszam` int(11) NOT NULL,
  `telepules` varchar(255) NOT NULL,
  `meret` bigint(11) UNSIGNED NOT NULL,
  `becsult ertek` bigint(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `telkek`
--

INSERT INTO `telkek` (`azonosito`, `helyrajzi szam`, `jelleg`, `iranyitoszam`, `telepules`, `meret`, `becsult ertek`) VALUES
(1, 3049, 2, 6722, 'Szeged I kerület', 296, 23680000),
(2, 3161, 2, 6722, 'Szeged I Kerület', 1128, 90240000),
(3, 3291, 2, 6722, 'Szeged I Kerület', 1102, 88160000),
(4, 3296, 2, 6722, 'Szeged I Kerület', 561, 44880000),
(5, 3467, 2, 6722, 'Szeged I Kerület', 575, 46000000),
(6, 3469, 2, 6722, 'Szeged I Kerület', 302, 24160000),
(7, 3470, 2, 6722, 'Szeged I Kerület', 572, 45760000),
(8, 3486, 2, 6722, 'Szeged I Kerület', 7517, 601360000),
(9, 3509, 2, 6722, 'Szeged I Kerület', 801, 64080000),
(10, 3513, 2, 6722, 'Szeged I Kerület', 540, 43200000),
(12, 3716, 2, 6725, 'Szeged I Kerület', 3628, 290240000),
(13, 3728, 2, 6720, 'Szeged I Kerület', 2630, 210400000),
(14, 3745, 2, 6720, 'Szeged I Kerület', 442, 35360000),
(15, 3760, 2, 6720, 'Szeged I Kerület', 1408, 112640000),
(16, 3847, 2, 6722, 'Szeged I Kerület', 13862, 1108960000),
(17, 3978, 2, 6722, 'Szeged I Kerület', 1701, 136080000),
(19, 1234, 1, 5630, 'Békés', 1000, 1000000),
(22, 2222, 4, 3950, 'Sárospatak', 1000, 400000);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `felhasznalok`
--
ALTER TABLE `felhasznalok`
  ADD PRIMARY KEY (`adojel`),
  ADD UNIQUE KEY `adojel` (`adojel`);

--
-- A tábla indexei `ingatlan jellegek`
--
ALTER TABLE `ingatlan jellegek`
  ADD PRIMARY KEY (`azonosito`);

--
-- A tábla indexei `ingatlanok`
--
ALTER TABLE `ingatlanok`
  ADD PRIMARY KEY (`azonosito`),
  ADD KEY `jelleg` (`jelleg`),
  ADD KEY `telek azonosito` (`telek azonosito`);

--
-- A tábla indexei `ingatlan tulajdonosok`
--
ALTER TABLE `ingatlan tulajdonosok`
  ADD KEY `ingatlan azonosito` (`ingatlan azonosito`),
  ADD KEY `tulajdonos adojel` (`tulajdonos adojel`);

--
-- A tábla indexei `telek jellegek`
--
ALTER TABLE `telek jellegek`
  ADD PRIMARY KEY (`azonosito`);

--
-- A tábla indexei `telek tulajdonosok`
--
ALTER TABLE `telek tulajdonosok`
  ADD KEY `telek azonosito` (`telek azonosito`),
  ADD KEY `tulajdonos adojel` (`tulajdonos adojel`);

--
-- A tábla indexei `telkek`
--
ALTER TABLE `telkek`
  ADD PRIMARY KEY (`azonosito`),
  ADD UNIQUE KEY `azonosito` (`azonosito`),
  ADD KEY `jelleg` (`jelleg`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `ingatlan jellegek`
--
ALTER TABLE `ingatlan jellegek`
  MODIFY `azonosito` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `ingatlanok`
--
ALTER TABLE `ingatlanok`
  MODIFY `azonosito` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT a táblához `telek jellegek`
--
ALTER TABLE `telek jellegek`
  MODIFY `azonosito` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `telkek`
--
ALTER TABLE `telkek`
  MODIFY `azonosito` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `ingatlanok`
--
ALTER TABLE `ingatlanok`
  ADD CONSTRAINT `ingatlanok_ibfk_1` FOREIGN KEY (`jelleg`) REFERENCES `ingatlan jellegek` (`azonosito`),
  ADD CONSTRAINT `ingatlanok_ibfk_2` FOREIGN KEY (`telek azonosito`) REFERENCES `telkek` (`azonosito`);

--
-- Megkötések a táblához `ingatlan tulajdonosok`
--
ALTER TABLE `ingatlan tulajdonosok`
  ADD CONSTRAINT `ingatlan tulajdonosok_ibfk_1` FOREIGN KEY (`ingatlan azonosito`) REFERENCES `ingatlanok` (`azonosito`),
  ADD CONSTRAINT `ingatlan tulajdonosok_ibfk_2` FOREIGN KEY (`tulajdonos adojel`) REFERENCES `felhasznalok` (`adojel`);

--
-- Megkötések a táblához `telek tulajdonosok`
--
ALTER TABLE `telek tulajdonosok`
  ADD CONSTRAINT `telek tulajdonosok_ibfk_1` FOREIGN KEY (`telek azonosito`) REFERENCES `telkek` (`azonosito`),
  ADD CONSTRAINT `telek tulajdonosok_ibfk_2` FOREIGN KEY (`tulajdonos adojel`) REFERENCES `felhasznalok` (`adojel`);

--
-- Megkötések a táblához `telkek`
--
ALTER TABLE `telkek`
  ADD CONSTRAINT `telkek_ibfk_1` FOREIGN KEY (`jelleg`) REFERENCES `telek jellegek` (`azonosito`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
