-- *********************************************
-- * SQL MySQL generation                      
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.2              
-- * Generator date: Sep 14 2021              
-- * Generation date: Thu Jun  2 11:52:09 2022 
-- * LUN file: C:\Users\sirri\OneDrive - Alma Mater Studiorum Università di Bologna\A.A. 2021-22 - Basi di Dati\DataRace\DataRace.lun 
-- * Schema: Logic/1 
-- ********************************************* 


-- Database Section
-- ________________ 

create database datarace;
use datarace;


-- Tables Section
-- _____________ 

create table AFFILIAZIONE (
     team char(50) not null,
     anno int not null,
     costruttore char(50) not null,
     constraint IDaffiliazione primary key (costruttore, team, anno));

create table CAMPIONATO (
     classe char(50) not null,
     anno int not null,
     numeroProve int not null,
     punteggio char(50) not null,
     constraint IDCAMPIONATO_ID primary key (classe, anno));

create table CIRCUITO (
     idCircuito char(50) not null,
     nome char(50) not null,
     localita char(100) not null,
     lunghezzaInMetri int not null,
     numeroCurveSinistra int not null,
     numeroCurveDestra int not null,
     lunghezzaRettilineoInMetri int not null,
     constraint IDCIRCUITO primary key (idCircuito));

create table CLASSE (
     nome char(50) not null,
     cilindrataMinima int not null,
     cilindrataMassima int not null,
     etaMinima int not null,
     etaMassima int not null,
     constraint IDCLASSE_ID primary key (nome));

create table COSTRUTTORE (
     idCostruttore char(50) not null,
     nome char(50) not null,
     annoDiEsordio int not null,
     paese char(50) not null,
     constraint IDCOSTRUTTORE primary key (idCostruttore));

create table GARA (
     idGara char(50) not null,
     classe char(50) not null,
     posizioneCalendario int not null,
     anno int not null,
     data date not null,
     oraInizio time not null,
     numeroGiri int not null,
     condizioniTracciato char(50) not null,
     constraint IDGARA_1 unique (classe),
     constraint IDGARA primary key (idGara));

create table GRAN_PREMIO (
     idGranPremio char(50) not null,
     denominazione char(100) not null,
     annoPrimaEdizione int not null,
     constraint IDGRAN_PREMIO primary key (idGranPremio));

create table ISCRIZIONE (
     pilota char(50) not null,
     classe char(50) not null,
     team char(50) not null,
     posizioneCalendario int not null,
     anno int not null,
     numeroDiGara int not null,
     tipoIscrizione char(50) not null,
     risultato char(50),
     costruttore char(50) not null,
     modello char(50) not null,
     constraint IDISCRIZIONE primary key (pilota, team, posizioneCalendario, anno, classe),
     constraint FKentrylist_gara_ID unique (risultato));

create table MODELLO (
     costruttore char(50) not null,
     nomeModello char(50) not null,
     constraint IDMODELLO primary key (costruttore, nomeModello));

create table PARTECIPAZIONE_COSTRUTTORE (
     costruttore char(50) not null,
     classe char(50) not null,
     anno int not null,
     punti int not null,
     posizioneClassifica int not null,
     constraint IDpartecipazione_costruttore primary key (classe, anno, costruttore));

create table PARTECIPAZIONE_PILOTA (
     classe char(50) not null,
     anno int not null,
     pilota char(50) not null,
     eta int not null,
     esperienza int not null,
     puntiTotali int not null,
     puntiValidi int,
     posizioneClassifica int not null,
     constraint IDpartecipazione_pilota primary key (classe, anno, pilota));

create table PARTECIPAZIONE_TEAM (
     classe char(50) not null,
     anno int not null,
     team char(50) not null,
     punti int not null,
     posizioneClassifica int not null,
     constraint IDpartecipazione_team primary key (classe, anno, team));

create table PILOTA (
     idPilota char(50) not null,
     nome char(50) not null,
     cognome char(50) not null,
     luogoDiNascita char(50) not null,
     nazionalita char(50) not null,
     dataDiNascita char(50) not null,
     constraint IDPILOTA_ID primary key (idPilota));

create table PROVA (
     anno int not null,
     posizioneCalendario int not null,
     granPremio char(100) not null,
     nomeUfficiale char(100) not null,
     numeroEdizione int not null,
     dataInizio date not null,
     dataFine date not null,
     numeroSpettatori int,
     circuito char(100) not null,
     constraint IDPROVA primary key (posizioneCalendario, anno),
     constraint FKedizione_ID unique (granPremio, numeroEdizione));

create table PUNTEGGIO (
     idPunteggio char(50) not null,
     risultato int not null,
     puntiAssegnati int not null,
     constraint IDPUNTEGGIO_ID primary key (idPunteggio, risultato));

create table RISULTATO (
     idRisultato char(50) not null,
     gara char(50) not null,
     posizionePartenza int not null,
     posizioneArrivo int not null,
     ritiro bool not null,
     tempoTotale time not null,
     giroVeloce time not null,
     giriInTesta int,
     constraint IDRISULTATO unique (posizioneArrivo, gara),
     constraint IDRISULTATO_1_ID primary key (idRisultato));

create table STAGIONE (
     anno int not null,
     numeroProve int not null,
     constraint IDSTAGIONE_ID primary key (anno));

create table STAGIONE_TEAM (
     nomeUfficiale char(50) not null,
     anno int not null,
     team char(50) not null,
     teamManager char(50) not null,
     constraint IDSTAGIONE_TEAM_1_ID primary key (nomeUfficiale, anno));

create table STATISTICHE_PILOTA (
     pilota char(50) not null,
     gareDisputate int not null,
     vittorie int not null,
     polePositions int not null,
     podi int not null,
     giriVeloci int not null,
     constraint FKcarriera_ID primary key (pilota));

create table TEAM (
     idTeam char(50) not null,
     nome char(50) not null,
     paese char(50) not null,
     tipo char(50) not null,
     constraint IDTEAM_ID primary key (idTeam));


-- Constraints Section
-- ___________________ 

alter table AFFILIAZIONE add constraint FKaff_COS
     foreign key (costruttore)
     references COSTRUTTORE (idCostruttore);

alter table AFFILIAZIONE add constraint FKaff_STA
     foreign key (team, anno)
     references STAGIONE_TEAM (nomeUfficiale, anno);

-- Not implemented
-- alter table CAMPIONATO add constraint IDCAMPIONATO_CHK
--     check(exists(select * from PARTECIPAZIONE_TEAM
--                  where PARTECIPAZIONE_TEAM.classe = classe and PARTECIPAZIONE_TEAM.anno = anno)); 

-- Not implemented
-- alter table CAMPIONATO add constraint IDCAMPIONATO_CHK
--     check(exists(select * from PARTECIPAZIONE_COSTRUTTORE
--                  where PARTECIPAZIONE_COSTRUTTORE.classe = classe and PARTECIPAZIONE_COSTRUTTORE.anno = anno)); 

-- Not implemented
-- alter table CAMPIONATO add constraint IDCAMPIONATO_CHK
--     check(exists(select * from PARTECIPAZIONE_PILOTA
--                  where PARTECIPAZIONE_PILOTA.classe = classe and PARTECIPAZIONE_PILOTA.anno = anno)); 

alter table CAMPIONATO add constraint FKofferta
     foreign key (anno)
     references STAGIONE (anno);

alter table CAMPIONATO add constraint FKutilizzo
     foreign key (punteggio)
     references PUNTEGGIO (idPunteggio);

alter table CAMPIONATO add constraint FKregolamento
     foreign key (classe)
     references CLASSE (nome);

-- Not implemented
-- alter table CLASSE add constraint IDCLASSE_CHK
--     check(exists(select * from CAMPIONATO
--                  where CAMPIONATO.classe = nome)); 

alter table GARA add constraint FKappartenenza
     foreign key (classe)
     references CLASSE (nome);

alter table GARA add constraint FKprogramma
     foreign key (posizioneCalendario, anno)
     references PROVA (posizioneCalendario, anno);

alter table ISCRIZIONE add constraint FKentrylist_gara_FK
     foreign key (risultato)
     references RISULTATO (idRisultato);

alter table ISCRIZIONE add constraint FKiscrizione_veicolo
     foreign key (costruttore, modello)
     references MODELLO (costruttore, nomeModello);

alter table ISCRIZIONE add constraint FKentrylist_prova
     foreign key (posizioneCalendario, anno)
     references PROVA (posizioneCalendario, anno);

alter table ISCRIZIONE add constraint FKiscrizione_team
     foreign key (team)
     references STAGIONE_TEAM (nomeUfficiale);

alter table ISCRIZIONE add constraint FKscelta_classe
     foreign key (classe)
     references CLASSE (nome);

alter table ISCRIZIONE add constraint FKiscrizione_pilota
     foreign key (pilota)
     references PILOTA (idPilota);

alter table MODELLO add constraint FKproduzione
     foreign key (costruttore)
     references COSTRUTTORE (idCostruttore);

alter table PARTECIPAZIONE_COSTRUTTORE add constraint FKpar_CAM
     foreign key (classe, anno)
     references CAMPIONATO (classe, anno);

alter table PARTECIPAZIONE_COSTRUTTORE add constraint FKpar_COS
     foreign key (costruttore)
     references COSTRUTTORE (idCostruttore);

alter table PARTECIPAZIONE_PILOTA add constraint FKPilota
     foreign key (pilota)
     references PILOTA (idPilota);

alter table PARTECIPAZIONE_PILOTA add constraint FKCampionato
     foreign key (classe, anno)
     references CAMPIONATO (classe, anno);

alter table PARTECIPAZIONE_TEAM add constraint FKpar1_CAM
     foreign key (classe, anno)
     references CAMPIONATO (classe, anno);

alter table PARTECIPAZIONE_TEAM add constraint FKR
     foreign key (team)
     references STAGIONE_TEAM (nomeUfficiale);

-- Not implemented
-- alter table PILOTA add constraint IDPILOTA_CHK
--     check(exists(select * from STATISTICHE_PILOTA
--                  where STATISTICHE_PILOTA.pilota = idPilota)); 

alter table PROVA add constraint FKcalendario
     foreign key (anno)
     references STAGIONE (anno);

alter table PROVA add constraint FKedizione_FK
     foreign key (granPremio)
     references GRAN_PREMIO (idGranPremio);

alter table PROVA add constraint FKsvolgimento
     foreign key (circuito)
     references CIRCUITO (idCircuito);

-- Not implemented
-- alter table PUNTEGGIO add constraint IDPUNTEGGIO_CHK
--     check(exists(select * from CAMPIONATO
--                  where CAMPIONATO.punteggio = idPunteggio)); 

alter table RISULTATO add constraint FKordine_arrivo
     foreign key (gara)
     references GARA (idGara);

-- Not implemented
-- alter table RISULTATO add constraint IDRISULTATO_1_CHK
--     check(exists(select * from ISCRIZIONE
--                  where ISCRIZIONE.risultato = idRisultato)); 

-- Not implemented
-- alter table STAGIONE add constraint IDSTAGIONE_CHK
--     check(exists(select * from PROVA
--                  where PROVA.anno = anno)); 

-- Not implemented
-- alter table STAGIONE add constraint IDSTAGIONE_CHK
--     check(exists(select * from STAGIONE_TEAM
--                  where STAGIONE_TEAM.anno = anno)); 

-- Not implemented
-- alter table STAGIONE add constraint IDSTAGIONE_CHK
--     check(exists(select * from CAMPIONATO
--                  where CAMPIONATO.anno = anno)); 

-- Not implemented
-- alter table STAGIONE_TEAM add constraint IDSTAGIONE TEAM_1_CHK
--     check(exists(select * from AFFILIAZIONE
--                  where AFFILIAZIONE.team = nomeUfficiale and AFFILIAZIONE.anno = anno)); 

-- Not implemented
-- alter table STAGIONE_TEAM add constraint IDSTAGIONE TEAM_1_CHK
--     check(exists(select * from PARTECIPAZIONE_TEAM
--                  where PARTECIPAZIONE_TEAM.team = nomeUfficiale)); 

alter table STAGIONE_TEAM add constraint FKorganizzazione
     foreign key (anno)
     references STAGIONE (anno);

alter table STAGIONE_TEAM add constraint FKR1
     foreign key (team)
     references TEAM (idTeam);

alter table STATISTICHE_PILOTA add constraint FKcarriera_FK
     foreign key (pilota)
     references PILOTA (idPilota);

-- Not implemented
-- alter table TEAM add constraint IDTEAM_CHK
--     check(exists(select * from STAGIONE_TEAM
--                  where STAGIONE_TEAM.team = idTeam)); 


-- Index Section
-- _____________ 

