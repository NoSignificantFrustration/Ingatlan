## Első iteráció

Felhasználók( <ins>azonosító</ins>, jelszó, név, adószám, lakcím, telefonszám, születési dátum, anyja neve, be van-e jelentkezve, utolsó belépés, szerepkör)

Telkek( <ins>helyrajzi szám</ins>, jelleg, méret, becsült érték)

Ingatlanok: ( <ins>ingatlan azonosítója</ins>, jellege, építés éve, irányítószám, település, közterület és házszám, becsült értéke)

Tulajdonosok( *telek helyrajzi száma*, *ingatlan azonosítója*, tulajdonos adószáma, tulajdonba kerülés dátuma, tulajdonhányad százalékban)

## Második iteráció

Felhasználók( <ins>adószám</ins>,  jelszó, név, lakcím, telefonszám, születési dátum, anyja neve, be van-e jelentkezve, utolsó belépés, szerepkör)

Telkek( <ins>helyrajzi szám</ins>, *jelleg*, irányítószám, település, közterület, méret, becsült érték)

Ingatlanok: ( <ins>ingatlan azonosítója</ins>, *helyrajzi szám*, *jellege*, építés éve,  házszám, becsült értéke)

Telek tulajdonosok( *telek helyrajzi száma*, *tulajdonos azonosítója*, tulajdonba kerülés dátuma, tulajdonhányad százalékban)

Ingatlan tulajdonosok( *ingatlan azonosítója*, *tulajdonos azonosítója*, tulajdonba kerülés dátuma, tulajdonhányad százalékban)

Telek jellegek( <ins>azonosító</ins>, név)
Ingatlan jellegek( <ins>azonosító</ins>, név)


```CREATE TABLE `ingatlanok`.`felhasznalok` (`adojel` BIGINT(10) NOT NULL UNIQUE, `jelszo` VARCHAR(255) NOT NULL , `nev` VARCHAR(255) NOT NULL , `lakcim` VARCHAR(255) NOT NULL , `telefonszam` BIGINT NOT NULL , `szuletesi datum` DATE NOT NULL , `anyja neve` VARCHAR(255) NOT NULL , `be van-e jelentkezve` BOOLEAN NOT NULL , `utolso belepes` DATETIME NOT NULL , `szerepkor` TINYINT UNSIGNED NOT NULL , PRIMARY KEY (`adojel`));```

```CREATE TABLE `ingatlanok`.`telek jellegek` (`azonosito` INT NOT NULL AUTO_INCREMENT , `nev` VARCHAR(255) NOT NULL , PRIMARY KEY (`azonosito`));```

```CREATE TABLE `ingatlanok`.`ingatlan jellegek` (`azonosito` INT NOT NULL AUTO_INCREMENT , `nev` VARCHAR(255) NOT NULL , PRIMARY KEY (`azonosito`));```

```CREATE TABLE `ingatlanok`.`telkek` (`helyrajzi szam` INT NOT NULL UNIQUE , `jelleg` INT NOT NULL , `iranyitoszam` INT NOT NULL, `kozterulet` VARCHAR(255) NOT NULL, `telepules` VARCHAR(255) NOT NULL , `meret` INT NOT NULL , `becsult ertek` INT NOT NULL , PRIMARY KEY (`helyrajzi szam`));```

```ALTER TABLE `telkek`
ADD FOREIGN KEY (`jelleg` )
REFERENCES `telek jellegek` (azonosito)```

```CREATE TABLE `ingatlanok`.`ingatlanok` (`azonosito` INT NOT NULL AUTO_INCREMENT , `helyrajzi szam` INT NOT NULL , `jelleg` INT NOT NULL , `epites eve` INT NOT NULL , `hazszam` VARCHAR(255) NOT NULL , `becsult ertek` INT NOT NULL , PRIMARY KEY (`azonosito`));```

```ALTER TABLE `ingatlanok`
ADD FOREIGN KEY (`jelleg` )
REFERENCES `ingatlan jellegek` (azonosito),
ADD FOREIGN KEY (`helyrajzi szam`)
REFERENCES `telkek` (`helyrajzi szam`)```


```CREATE TABLE `ingatlanok`.`telek tulajdonosok` (`helyrajzi szam` INT NOT NULL , `tulajdonos adojel` BIGINT NOT NULL , `tulajdonba kerules datuma` DATE NOT NULL , `tulajdonhanyad` INT NOT NULL );```

```ALTER TABLE `telek tulajdonosok`
ADD FOREIGN KEY (`helyrajzi szam`)
REFERENCES telkek (`helyrajzi szam`),
ADD FOREIGN KEY (`tulajdonos adojel`)
REFERENCES felhasznalok (`adojel`)```

```CREATE TABLE `ingatlanok`.`ingatlan tulajdonosok` (`ingatlan azonosito` INT NOT NULL , `tulajdonos adojel` BIGINT NOT NULL , `tulajdonba kerules datuma` DATE NOT NULL , `tulajdonhanyad` INT NOT NULL );```

```ALTER TABLE `ingatlan tulajdonosok`
ADD FOREIGN KEY (`ingatlan azonosito`)
REFERENCES ingatlanok (`azonosito`),
ADD FOREIGN KEY (`tulajdonos adojel`)
REFERENCES felhasznalok (`adojel`)```