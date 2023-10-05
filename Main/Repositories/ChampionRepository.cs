//ChampionRepository.cs file. Located in the Repositories folder.
using System;
using System.Linq;
using System.Collections.Generic;
using SampleProj.Models;

namespace SampleProj.Repository
{
    public class ChampionRepository
    {
       private List<Champion> _champions;

       public ChampionRepository()
       {
            _champions = new List<Champion> 
            {
                new Champion { Id = 1, Name = "Aatrox", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Aatrox_0.jpg" },
                new Champion { Id = 2, Name = "Ahri", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_0.jpg" },
                new Champion { Id = 3, Name = "Akali", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Akali_0.jpg" },
                new Champion { Id = 4, Name = "Alistar", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Alistar_0.jpg" },
                new Champion { Id = 5, Name = "Amumu", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Amumu_0.jpg" },
                new Champion { Id = 6, Name = "Anivia", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Anivia_0.jpg" },
                new Champion { Id = 7, Name = "Annie", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Annie_0.jpg" },
                new Champion { Id = 8, Name = "Ashe", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ashe_0.jpg" },
                new Champion { Id = 9, Name = "Aurelion Sol", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/AurelionSol_0.jpg" },
                new Champion { Id = 10, Name = "Azir", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Azir_0.jpg" },
                new Champion { Id = 11, Name = "Bard", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Bard_0.jpg" },
                new Champion { Id = 12, Name = "Blitzcrank", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Blitzcrank_0.jpg" },
                new Champion { Id = 13, Name = "Brand", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Brand_0.jpg" },
                new Champion { Id = 14, Name = "Braum", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Braum_0.jpg" },
                new Champion { Id = 15, Name = "Caitlyn", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Caitlyn_0.jpg" },
                new Champion { Id = 16, Name = "Camille", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Camille_0.jpg" },
                new Champion { Id = 17, Name = "Cassiopeia", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Cassiopeia_0.jpg" },
                new Champion { Id = 18, Name = "Cho'Gath", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Chogath_0.jpg" },
                new Champion { Id = 19, Name = "Corki", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Corki_0.jpg" },
                new Champion { Id = 20, Name = "Darius", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Darius_0.jpg" },
                new Champion { Id = 21, Name = "Diana", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Diana_0.jpg" },
                new Champion { Id = 22, Name = "Dr. Mundo", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/DrMundo_0.jpg" },
                new Champion { Id = 23, Name = "Draven", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Draven_0.jpg" },
                new Champion { Id = 24, Name = "Ekko", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ekko_0.jpg" },
                new Champion { Id = 25, Name = "Elise", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Elise_0.jpg" },
                new Champion { Id = 26, Name = "Evelynn", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Evelynn_0.jpg" },
                new Champion { Id = 27, Name = "Ezreal", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ezreal_0.jpg" },
                new Champion { Id = 28, Name = "Fiddlesticks", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiddlesticks_0.jpg" },
                new Champion { Id = 29, Name = "Fiora", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiora_0.jpg" },
                new Champion { Id = 30, Name = "Fizz", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fizz_0.jpg" },
                new Champion { Id = 31, Name = "Galio", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Galio_0.jpg" },
                new Champion { Id = 32, Name = "Gangplank", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gangplank_0.jpg" },
                new Champion { Id = 33, Name = "Garen", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Garen_0.jpg" },
                new Champion { Id = 34, Name = "Gnar", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gnar_0.jpg" },
                new Champion { Id = 35, Name = "Gragas", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gragas_0.jpg" },
                new Champion { Id = 36, Name = "Graves", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Graves_0.jpg" },
                new Champion { Id = 37, Name = "Hecarim", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Hecarim_0.jpg" },
                new Champion { Id = 38, Name = "Heimerdinger", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Heimerdinger_0.jpg" },
                new Champion { Id = 39, Name = "Illaoi", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Illaoi_0.jpg" },
                new Champion { Id = 40, Name = "Irelia", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Irelia_0.jpg" },
                new Champion { Id = 41, Name = "Ivern", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ivern_0.jpg" },
                new Champion { Id = 42, Name = "Janna", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Janna_0.jpg" },
                new Champion { Id = 43, Name = "Jarvan IV", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/JarvanIV_0.jpg" },
                new Champion { Id = 44, Name = "Jax", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jax_0.jpg" },
                new Champion { Id = 45, Name = "Jayce", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jayce_0.jpg" },
                new Champion { Id = 46, Name = "Jhin", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jhin_0.jpg" },
                new Champion { Id = 47, Name = "Jinx", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jinx_0.jpg" },
                new Champion { Id = 48, Name = "Kalista", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kalista_0.jpg" },
                new Champion { Id = 49, Name = "Karma", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Karma_0.jpg" },
                new Champion { Id = 50, Name = "Karthus", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Karthus_0.jpg" },
                new Champion { Id = 51, Name = "Kassadin", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kassadin_0.jpg" },
                new Champion { Id = 52, Name = "Katarina", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Katarina_0.jpg" },
                new Champion { Id = 53, Name = "Kayle", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kayle_0.jpg" },
                new Champion { Id = 54, Name = "Kayn", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kayn_0.jpg" },
                new Champion { Id = 55, Name = "Kennen", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kennen_0.jpg" },
                new Champion { Id = 56, Name = "Kha'Zix", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Khazix_0.jpg" },
                new Champion { Id = 57, Name = "Kindred", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kindred_0.jpg" },
                new Champion { Id = 58, Name = "Kled", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kled_0.jpg" },
                new Champion { Id = 59, Name = "Kog'Maw", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/KogMaw_0.jpg" },
                new Champion { Id = 60, Name = "LeBlanc", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Leblanc_0.jpg" },
                new Champion { Id = 61, Name = "Lee Sin", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/LeeSin_0.jpg" },
                new Champion { Id = 62, Name = "Leona", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Leona_0.jpg" },
                new Champion { Id = 63, Name = "Lissandra", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lissandra_0.jpg" },
                new Champion { Id = 64, Name = "Lucian", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lucian_0.jpg" },
                new Champion { Id = 65, Name = "Lulu", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lulu_0.jpg" },
                new Champion { Id = 66, Name = "Lux", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lux_0.jpg" },
                new Champion { Id = 67, Name = "Malphite", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Malphite_0.jpg" },
                new Champion { Id = 68, Name = "Malzahar", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Malzahar_0.jpg" },
                new Champion { Id = 69, Name = "Maokai", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Maokai_0.jpg" },
                new Champion { Id = 70, Name = "Master Yi", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/MasterYi_0.jpg" },
                new Champion { Id = 71, Name = "Miss Fortune", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/MissFortune_0.jpg" },
                new Champion { Id = 72, Name = "Mordekaiser", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Mordekaiser_0.jpg" },
                new Champion { Id = 73, Name = "Morgana", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Morgana_0.jpg" },
                new Champion { Id = 74, Name = "Nami", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nami_0.jpg" },
                new Champion { Id = 75, Name = "Nasus", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nasus_0.jpg" },
                new Champion { Id = 76, Name = "Nautilus", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nautilus_0.jpg" },
                new Champion { Id = 77, Name = "Nidalee", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nidalee_0.jpg" },
                new Champion { Id = 78, Name = "Nocturne", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nocturne_0.jpg" },
                new Champion { Id = 79, Name = "Nunu", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nunu_0.jpg" },
                new Champion { Id = 80, Name = "Olaf", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Olaf_0.jpg" },
                new Champion { Id = 81, Name = "Orianna", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Orianna_0.jpg" },
                new Champion { Id = 82, Name = "Ornn", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ornn_0.jpg" },
                new Champion { Id = 83, Name = "Pantheon", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Pantheon_0.jpg" },
                new Champion { Id = 84, Name = "Poppy", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Poppy_0.jpg" },
                new Champion { Id = 85, Name = "Pyke", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Pyke_0.jpg" },
                new Champion { Id = 86, Name = "Qiyana", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Qiyana_0.jpg" },
                new Champion { Id = 87, Name = "Quinn", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Quinn_0.jpg" },
                new Champion { Id = 88, Name = "Rakan", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rakan_0.jpg" },
                new Champion { Id = 89, Name = "Rammus", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rammus_0.jpg" },
                new Champion { Id = 90, Name = "Rek'Sai", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/RekSai_0.jpg" },
                new Champion { Id = 91, Name = "Renekton", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Renekton_0.jpg" },
                new Champion { Id = 92, Name = "Rengar", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rengar_0.jpg" },
                new Champion { Id = 93, Name = "Riven", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Riven_0.jpg" },
                new Champion { Id = 94, Name = "Rumble", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rumble_0.jpg" },
                new Champion { Id = 95, Name = "Ryze", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ryze_0.jpg" },
                new Champion { Id = 96, Name = "Sejuani", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sejuani_0.jpg" },
                new Champion { Id = 97, Name = "Senna", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Senna_0.jpg" },
                new Champion { Id = 98, Name = "Sett", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sett_0.jpg" },
                new Champion { Id = 99, Name = "Shaco", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Shaco_0.jpg" },
                new Champion { Id = 100, Name = "Shen", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Shen_0.jpg" },
                new Champion { Id = 101, Name = "Shyvana", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Shyvana_0.jpg" },
                new Champion { Id = 102, Name = "Singed", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Singed_0.jpg" },
                new Champion { Id = 103, Name = "Sion", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sion_0.jpg" },
                new Champion { Id = 104, Name = "Sivir", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sivir_0.jpg" },
                new Champion { Id = 105, Name = "Skarner", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Skarner_0.jpg" },
                new Champion { Id = 106, Name = "Sona", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sona_0.jpg" },
                new Champion { Id = 107, Name = "Soraka", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Soraka_0.jpg" },
                new Champion { Id = 108, Name = "Swain", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Swain_0.jpg" },
                new Champion { Id = 109, Name = "Sylas", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sylas_0.jpg" },
                new Champion { Id = 110, Name = "Syndra", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Syndra_0.jpg" },
                new Champion { Id = 111, Name = "Tahm Kench", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/TahmKench_0.jpg" },
                new Champion { Id = 112, Name = "Taliyah", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Taliyah_0.jpg" },
                new Champion { Id = 113, Name = "Talon", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Talon_0.jpg" },
                new Champion { Id = 114, Name = "Taric", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Taric_0.jpg" },
                new Champion { Id = 115, Name = "Teemo", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Teemo_0.jpg" },
                new Champion { Id = 116, Name = "Thresh", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Thresh_0.jpg" },
                new Champion { Id = 117, Name = "Tristana", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Tristana_0.jpg" },
                new Champion { Id = 118, Name = "Trundle", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Trundle_0.jpg" },
                new Champion { Id = 119, Name = "Tryndamere", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Tryndamere_0.jpg" },
                new Champion { Id = 120, Name = "Twisted Fate", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/TwistedFate_0.jpg" },
                new Champion { Id = 121, Name = "Twitch", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Twitch_0.jpg" },
                new Champion { Id = 122, Name = "Udyr", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Udyr_0.jpg" },
                new Champion { Id = 123, Name = "Urgot", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Urgot_0.jpg" },
                new Champion { Id = 124, Name = "Varus", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Varus_0.jpg" },
                new Champion { Id = 125, Name = "Vayne", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Vayne_0.jpg" },
                new Champion { Id = 126, Name = "Veigar", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Veigar_0.jpg" },
                new Champion { Id = 127, Name = "Vel'Koz", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Velkoz_0.jpg" },
                new Champion { Id = 128, Name = "Vi", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Vi_0.jpg" },
                new Champion { Id = 129, Name = "Viktor", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Viktor_0.jpg" },
                new Champion { Id = 130, Name = "Vladimir", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Vladimir_0.jpg" },
                new Champion { Id = 131, Name = "Volibear", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Volibear_0.jpg" },
                new Champion { Id = 132, Name = "Warwick", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Warwick_0.jpg" },
                new Champion { Id = 133, Name = "Wukong", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/MonkeyKing_0.jpg" },
                new Champion { Id = 134, Name = "Xayah", Category = "Marksman", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Xayah_0.jpg" },
                new Champion { Id = 135, Name = "Xerath", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Xerath_0.jpg" },
                new Champion { Id = 136, Name = "Xin Zhao", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/XinZhao_0.jpg" },
                new Champion { Id = 137, Name = "Yasuo", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yasuo_0.jpg" },
                new Champion { Id = 138, Name = "Yorick", Category = "Fighter", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yorick_0.jpg" },
                new Champion { Id = 139, Name = "Yuumi", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yuumi_0.jpg" },
                new Champion { Id = 140, Name = "Zac", Category = "Tank", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zac_0.jpg" },
                new Champion { Id = 141, Name = "Zed", Category = "Assassin", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zed_0.jpg" },
                new Champion { Id = 142, Name = "Ziggs", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ziggs_0.jpg" },
                new Champion { Id = 143, Name = "Zilean", Category = "Support", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zilean_0.jpg" },
                new Champion { Id = 144, Name = "Zoe", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zoe_0.jpg" },
                new Champion { Id = 145, Name = "Zyra", Category = "Mage", ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zyra_0.jpg" }


            };
       }

        // You can add methods to retrieve champion data here
        public List<Champion> GetAllChampions()
        {
            return _champions;
        }




        public List<Champion> GetChampionsByCategory(string category)
        {
            return _champions.Where(champion => champion.Category == category).ToList();
        }

        public List<Champion> GetChampionsByPartialName(string name)
        {
            return _champions.Where(champion => champion.Name.ToLower().Contains(name.ToLower())).ToList();
        }

    }
}
