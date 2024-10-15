# Real-World Biome Map Creator
Een C# Coding Challenge waarbij de uitdaging is om real-world data om te zetten naar Minecraft biome- en height map-data. Het doel is om geografische gegevens zoals hoogtes en klimaatzones te vertalen naar een Minecraft-wereld, waarbij elke regio overeenkomt met een specifieke biome en hoogteverschillen worden weergegeven op de hoogtekaart.

## Beschrijving van de opdracht
Minecraft werkt met een x,y (of x,z in de game) coördinatenraster, waarbij elke x,y-positie een biome toegewezen krijgt, zoals oceaan, grasland, enzovoort. 'Floris' wil nu een Minecraft-plugin maken die data uit de echte wereld omzet naar Minecraft-data. 
Het belangrijkste is om te bepalen welk biome er op welke positie moet komen en wat de hoogte (z-positie) op die locatie moet zijn. Gebruik verschillende API's om real-world data om te zetten en sla het resultaat op (bonus).

### Requirements
- Elk x,y-coördinaat moet een specifieke biome krijgen, gebaseerd op real-world data.
- Voor elk coördinaat moet ook een hoogte worden vastgesteld, met een waarde tussen 0 en 384.

### Tips
- Raadpleeg de Minecraft-wiki voor meer informatie over biomes en de kenmerken daarvan.
- Maak gebruik van verschillende bronnen, zoals klimaatdata, gemiddelde jaartemperatuur, of andere relevante datasets om nauwkeurig biomes toe te wijzen.

## Documentatie
- Minecraft biome IDs - https://minecraft.fandom.com/wiki/Biome/ID 

## Commands om uit te voeren
- cd C:\Users\...\RiderProjects\RealWorldBiomeMapCreator\RealWorldBiomeMapCreator
- dotnet add package SixLabors.ImageSharp --version 3.1.5
- pip install requests
