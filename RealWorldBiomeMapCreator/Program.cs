using RealWorldBiomeMapCreator.Tiles;

namespace RealWorldBiomeMapCreator;

public class Program
{
    public static async Task Main(string[] args)
    {
        TileDownloader tileDownloader = new TileDownloader();

        /*
           Hieronder zie je een voorbeeld van het downloaden en analyseren van één tile.
           Let op: deze uitwerking is nog niet compleet, en de gebruikte tile is niet correct.
           Plaatsnamen (zwarte letters) worden namelijk gedetecteerd, maar die kunnen niet gebruikt worden om een biome te bepalen.
        
           Je opdracht is om minimaal 3 tiles met elkaar te combineren om te bepalen welke biome het beste past bij dat gebied.
           Er zijn veel verschillende biomes (zie de Biome enum), dus denk goed na over de logica waarmee je deze kiest!
        
           Bonus: Als je toch bezig bent met het analyseren van kaarten, bedenk ook welke hoogte bij elke locatie hoort en sla zowel de biome als de hoogte op in de SurfaceSafer.
        
           Het beste resultaat wint een prijs én wordt gebruikt als basis voor een Minecraft World Generator die we lanceren tijdens de Game Night.
        
           BELANGRIJK: Download niet te veel tiles achter elkaar, anders loop je het risico om geblokkeerd te worden.
           Sla gedownloade tiles lokaal op (cache ze) en controleer altijd of ze al bestaan voordat je ze opnieuw downloadt!
        */
        
          // Download een tile. Probeer ook andere locaties uit de wereld om verschillende biomes te verkennen.
        
          // Zoom uitleg: Zoom 0 betekent dat de wereld is opgedeeld in 1x1 tile. Zoom 1 deelt de wereld op in 2x2 tiles, zoom 2 in 4x4 tiles, en zo verder.
          // Bij zoom 7 (de huidige instelling) is de wereld opgedeeld in 128x128 tiles. (We tellen vanaf 0, dus van 0 t/m 127).
          // De huidige coördinaten komen uit een deel van Nederland, maar voor het eindresultaat is het beter om zoom 9 te gebruiken, wat de wereld opdeelt in 512x512 tiles.
        
        int worldX = 64;
        int worldY = 42;
        SatelliteTile satelliteTile = new SatelliteTile(await tileDownloader.DownloadTile(worldX, worldY, 7));

        // @TODO (Bonus): Maak deze analyse multithreaded, zodat het sneller wordt om de hele wereld te laden.
        satelliteTile.AnalyzeTile();

        // @TODO (Bonus): Doe iets met result. Save as file? Misschien weer als een image? Zorg ervoor dat de output makkelijk te lezen is.
    }
}