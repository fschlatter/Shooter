# Bean Shooter
### Dokumentace
#### Verze editoru: 2022.3.28f1 LTS
#### Využité unity balíčky (mimo vestavěné)
Input System (1.7.0) - Slouží pro získání vstupu z klávesnice a myši  
Post Processing (3.4.0) - Post Processing efekty  
Pro Builder (5.2.2) - Tvorba specifických 3D objektů přímo v editoru  
TextMeshPro (3.0.9) - Lépe vypadající UI text  
Unity UI (1.0.0) - UI nástroje od Unity  
#### Základní designové prvky hry
- Menu obrazovka s výběrem levelů a vysvětlením ovládání
- Dva typy podlahy, rozdíl je v klouzavosti a textuře
- Nepřátelé se otáčí za hráčem a pomocí fyziky se směrem ke hráči vyvine síla
- Pokud se hráč nepřítele dotkne level se restartuje
#### Ovládání
- LMB - střelba
- Space - brždění
- R - přebití zbraně
- Pohyb je založen na zpětném rázu zbraně
#### Levely
Level 1:  Základní level s deseti nepřáteli  
Level 2:  Dlouhý koridor do velké místnosti s dvaceti nepřáteli  
Level 3:  Zakroucený koridor s malou nepřátelskou místností, vede do velké místnosti s šestnácti nepřáteli  
Level 4:  Aréna se čtyřmi vlnami nepřátel kde každá vlna má o šest nepřátel více  
Level 5:  Velká oktagonální aréna s hlavním bossem, který háže bomby po hráči  
#### Assety
Všechny assety (materíály, prefaby, kód, textury, atd.) jsem vytvořil já (mimo vestavěné) pomocí vestavěných funkcí unity, ProBuilderu nebo externího softwaru jako GIMP
#### Známé bugy
- Když je hráč dostatečně rychlý může se dostat z hranic mapy (řešení neexistuje, je to problém fyziky unity enginu)
