# Spordiklubi-haldus

Projekti kirjeldus: 
Antud veebirakendus on loodud õppeaine "Programmeerimine I (TAR)" raames meeskondliku projektina. 

Süsteemi peamiseks eesmärgiks on muuta spordiklubi administraatori igapäevane töö lihtsamaks, kiiremaks ja mugavamaks.
Rakendus koondab kaikki spordiklubi andmed ühte tsentraalsesse kohta, asendades vanad paberid ja hajutatud Exceli tabelid. Administraatoril on reaalajas ülevaade klubi liikmetest ja treeneritest ning ta saab andmeid mugavalt vaadata, lisada, muuta ja kustutada.

Kasutatud tehnoloogiad:
Programmeerimiskeel: C#
Raamistik: ASP.NET Core MVC
Andmebaas: In-Memory Database (mälusisene andmebaas kiireks arenduseks ja testimiseks)
Kasutajaliides: HTML5, CSS3, Bootstrap 5 (mobiilisõbralik ja puhas disain)

Paigaldusjuhend:
Projekti käivitamiseks kohalikus arvutis veenduge, et teil on paigaldatud .NET 8.0 SDK (või uuem) ja Visual Studio 2022.
Klonige repositoorium oma arvutisse:

Bash
git clone https://github.com/Ossu-V/Spordiklubi-haldus.git

Avage projektifail Spordiklubi_haldus.sln Visual Studios.
Enne käivitamist tehke projektile Restore NuGet Packages, et laadida alla vajalikud paketid.
Vajutage Visual Studios Start / Run nuppu (või kasutage käsurida dotnet run), mis käivitab rakenduse lokaalses serveris (tavaliselt aadressil localhost).

Kasutusjuhend:
Avaleht: Süsteemi sisenemisel tervitab kasutajat puhas eestikeelne avaleht, kus asuvad otseteed peamiste moodulite juurde.
Liikmete haldus (Members): Menüülingist "Liikmed" avaneb spordiklubi klientide nimekiri. Süsteem laeb käivitamisel automaatselt koodist (DbInitializer) näidisandmed. Administraator saab vajutada nuppu "Lisa uus liige", täita vormi ja salvestada uue isiku. Iga rea lõpus on valikud andmete muutmiseks, detailide vaatamiseks või kustutamiseks.
Treenerite register (Trainers): Eraldi moodul klubi personali ja treenerite haldamiseks, mis kuvab töötaja nime ning tema täpse spetsialiseerumise ehk eriala.

Tehisintellekti (AI) kasutamine ja allikad:
Koodi parandamine ja eestindamine: Kasutasime AI-d abilisena, et leida ja kustutada koodigeneraatori tekitatud vigane Memberships lahter, mis kuvas ekraanile arusaamatut teksti. Lisaks andis AI täpsed juhised ja koodinäited, kuidas andmetabeli pealkirjad ning lingid (Create New, Edit, Details, Delete) korrektselt eesti keelde tõlkida.
Plagiaadi puudumine: Projekti funktsionaalsus ja loogika on meeskonna enda kirjutatud ning kohandatud. AI-d ei kasutatud valmis lahenduste kopeerimiseks, vaid ainult olemasoleva koodi parandamiseks ja õppimiseks. Kogu töö on unikaalne.
