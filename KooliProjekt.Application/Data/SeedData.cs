using System;
using System.Collections.Generic;
using System.Linq;

namespace KooliProjekt.Application.Data
{
	public static class SeedData
	{
		public static void Generate(ApplicationDbContext context)
		{
			SeedUsers(context);
			SeedProjects(context);
			SeedTasks(context);
			SeedLogs(context);
		}

		private static void SeedUsers(ApplicationDbContext context)
		{
			if (context.Set<user>().Any())
			{
				return;
			}

			var users = new List<user>
			{
				new user { name = "Mari Tamm", email = "mari.tamm@example.com", password = "DemoPass!2026-01" },
				new user { name = "Jaan Kask", email = "jaan.kask@example.com", password = "DemoPass!2026-02" },
				new user { name = "Liis Saar", email = "liis.saar@example.com", password = "DemoPass!2026-03" },
				new user { name = "Karl Mägi", email = "karl.magi@example.com", password = "DemoPass!2026-04" },
				new user { name = "Anna Pärn", email = "anna.parn@example.com", password = "DemoPass!2026-05" },
				new user { name = "Martin Sepp", email = "martin.sepp@example.com", password = "DemoPass!2026-06" },
				new user { name = "Kertu Kivi", email = "kertu.kivi@example.com", password = "DemoPass!2026-07" },
				new user { name = "Rasmus Vaher", email = "rasmus.vaher@example.com", password = "DemoPass!2026-08" },
				new user { name = "Laura Kuusk", email = "laura.kuusk@example.com", password = "DemoPass!2026-09" },
				new user { name = "Markus Oja", email = "markus.oja@example.com", password = "DemoPass!2026-10" },
				new user { name = "Kristiina Ilves", email = "kristiina.ilves@example.com", password = "DemoPass!2026-11" },
				new user { name = "Andres Lepp", email = "andres.lepp@example.com", password = "DemoPass!2026-12" },
				new user { name = "Grete Raud", email = "grete.raud@example.com", password = "DemoPass!2026-13" },
				new user { name = "Mihkel Lill", email = "mihkel.lill@example.com", password = "DemoPass!2026-14" },
				new user { name = "Eliise Põld", email = "eliise.pold@example.com", password = "DemoPass!2026-15" },
				new user { name = "Siim Mets", email = "siim.mets@example.com", password = "DemoPass!2026-16" },
				new user { name = "Triin Järv", email = "triin.jarv@example.com", password = "DemoPass!2026-17" },
				new user { name = "Kevin Toom", email = "kevin.toom@example.com", password = "DemoPass!2026-18" },
				new user { name = "Sandra Sild", email = "sandra.sild@example.com", password = "DemoPass!2026-19" },
				new user { name = "Erik Rebane", email = "erik.rebane@example.com", password = "DemoPass!2026-20" },
				new user { name = "Helena Kalda", email = "helena.kalda@example.com", password = "DemoPass!2026-21" },
				new user { name = "Robin Aas", email = "robin.aas@example.com", password = "DemoPass!2026-22" },
				new user { name = "Kadri Kukk", email = "kadri.kukk@example.com", password = "DemoPass!2026-23" },
				new user { name = "Taavi Rätsep", email = "taavi.ratsep@example.com", password = "DemoPass!2026-24" },
				new user { name = "Merilin Koppel", email = "merilin.koppel@example.com", password = "DemoPass!2026-25" },
				new user { name = "Priit Hallik", email = "priit.hallik@example.com", password = "DemoPass!2026-26" },
				new user { name = "Sofia Nurm", email = "sofia.nurm@example.com", password = "DemoPass!2026-27" },
				new user { name = "Oliver Roos", email = "oliver.roos@example.com", password = "DemoPass!2026-28" },
				new user { name = "Johanna Paju", email = "johanna.paju@example.com", password = "DemoPass!2026-29" },
				new user { name = "Rainer Teder", email = "rainer.teder@example.com", password = "DemoPass!2026-30" },
				new user { name = "Birgit Vool", email = "birgit.vool@example.com", password = "DemoPass!2026-31" },
				new user { name = "Hendrik Aavik", email = "hendrik.aavik@example.com", password = "DemoPass!2026-32" },
				new user { name = "Mirjam Kaar", email = "mirjam.kaar@example.com", password = "DemoPass!2026-33" },
				new user { name = "Artur Sokk", email = "artur.sokk@example.com", password = "DemoPass!2026-34" },
				new user { name = "Evelin Rand", email = "evelin.rand@example.com", password = "DemoPass!2026-35" }
			};

			context.Set<user>().AddRange(users);
			context.SaveChanges();
		}

		private static void SeedProjects(ApplicationDbContext context)
		{
			if (context.Set<project>().Any())
			{
				return;
			}

			var projects = new List<project>
			{
				new project { name = "Kliendiportaal", start = new DateTime(2025, 1, 6).AddDays(0), Deadline = new DateTime(2025, 1, 6).AddDays(70), buget = 9500m, hourlyRate = 55m, team = "Veebiarenduse tiim" },
				new project { name = "Laoarvestus", start = new DateTime(2025, 1, 6).AddDays(14), Deadline = new DateTime(2025, 1, 6).AddDays(98), buget = 12000m, hourlyRate = 60m, team = "Andmebaaside tiim" },
				new project { name = "E-poe mobiilivaade", start = new DateTime(2025, 1, 6).AddDays(28), Deadline = new DateTime(2025, 1, 6).AddDays(126), buget = 14500m, hourlyRate = 65m, team = "Mobiiliarenduse tiim" },
				new project { name = "Tööajaarvestus", start = new DateTime(2025, 1, 6).AddDays(42), Deadline = new DateTime(2025, 1, 6).AddDays(154), buget = 17000m, hourlyRate = 70m, team = "Integratsioonide tiim" },
				new project { name = "Koolituste portaal", start = new DateTime(2025, 1, 6).AddDays(56), Deadline = new DateTime(2025, 1, 6).AddDays(182), buget = 19500m, hourlyRate = 75m, team = "Ärianalüüsi tiim" },
				new project { name = "Veebilehe uuendus", start = new DateTime(2025, 1, 6).AddDays(70), Deadline = new DateTime(2025, 1, 6).AddDays(140), buget = 22000m, hourlyRate = 80m, team = "Testimise tiim" },
				new project { name = "Arvete automaatika", start = new DateTime(2025, 1, 6).AddDays(84), Deadline = new DateTime(2025, 1, 6).AddDays(168), buget = 24500m, hourlyRate = 55m, team = "Tootearenduse tiim" },
				new project { name = "Klienditoe süsteem", start = new DateTime(2025, 1, 6).AddDays(98), Deadline = new DateTime(2025, 1, 6).AddDays(196), buget = 27000m, hourlyRate = 60m, team = "Veebiarenduse tiim" },
				new project { name = "Personaliportaal", start = new DateTime(2025, 1, 6).AddDays(112), Deadline = new DateTime(2025, 1, 6).AddDays(224), buget = 10750m, hourlyRate = 65m, team = "Andmebaaside tiim" },
				new project { name = "Broneerimisplatvorm", start = new DateTime(2025, 1, 6).AddDays(126), Deadline = new DateTime(2025, 1, 6).AddDays(252), buget = 13250m, hourlyRate = 70m, team = "Mobiiliarenduse tiim" },
				new project { name = "Projektide töölaud", start = new DateTime(2025, 1, 6).AddDays(140), Deadline = new DateTime(2025, 1, 6).AddDays(210), buget = 15750m, hourlyRate = 75m, team = "Integratsioonide tiim" },
				new project { name = "Tarnete jälgimine", start = new DateTime(2025, 1, 6).AddDays(154), Deadline = new DateTime(2025, 1, 6).AddDays(238), buget = 18250m, hourlyRate = 80m, team = "Ärianalüüsi tiim" },
				new project { name = "Dokumendihaldus", start = new DateTime(2025, 1, 6).AddDays(168), Deadline = new DateTime(2025, 1, 6).AddDays(266), buget = 20750m, hourlyRate = 55m, team = "Testimise tiim" },
				new project { name = "Tootekataloog", start = new DateTime(2025, 1, 6).AddDays(182), Deadline = new DateTime(2025, 1, 6).AddDays(294), buget = 23250m, hourlyRate = 60m, team = "Tootearenduse tiim" },
				new project { name = "Küsitluste portaal", start = new DateTime(2025, 1, 6).AddDays(196), Deadline = new DateTime(2025, 1, 6).AddDays(322), buget = 25750m, hourlyRate = 65m, team = "Veebiarenduse tiim" },
				new project { name = "Müügiaruanded", start = new DateTime(2025, 1, 6).AddDays(210), Deadline = new DateTime(2025, 1, 6).AddDays(280), buget = 28250m, hourlyRate = 70m, team = "Andmebaaside tiim" },
				new project { name = "Ürituste haldus", start = new DateTime(2025, 1, 6).AddDays(224), Deadline = new DateTime(2025, 1, 6).AddDays(308), buget = 12000m, hourlyRate = 75m, team = "Mobiiliarenduse tiim" },
				new project { name = "Raamatukogu süsteem", start = new DateTime(2025, 1, 6).AddDays(238), Deadline = new DateTime(2025, 1, 6).AddDays(336), buget = 14500m, hourlyRate = 80m, team = "Integratsioonide tiim" },
				new project { name = "Hooldustööde kalender", start = new DateTime(2025, 1, 6).AddDays(252), Deadline = new DateTime(2025, 1, 6).AddDays(364), buget = 17000m, hourlyRate = 55m, team = "Ärianalüüsi tiim" },
				new project { name = "Raamatupidamise liides", start = new DateTime(2025, 1, 6).AddDays(266), Deadline = new DateTime(2025, 1, 6).AddDays(392), buget = 19500m, hourlyRate = 60m, team = "Testimise tiim" },
				new project { name = "Inventuuri mobiiliäpp", start = new DateTime(2025, 1, 6).AddDays(280), Deadline = new DateTime(2025, 1, 6).AddDays(350), buget = 22000m, hourlyRate = 65m, team = "Tootearenduse tiim" },
				new project { name = "Kinnisvaraportaal", start = new DateTime(2025, 1, 6).AddDays(294), Deadline = new DateTime(2025, 1, 6).AddDays(378), buget = 24500m, hourlyRate = 70m, team = "Veebiarenduse tiim" },
				new project { name = "Spordiklubi portaal", start = new DateTime(2025, 1, 6).AddDays(308), Deadline = new DateTime(2025, 1, 6).AddDays(406), buget = 27000m, hourlyRate = 75m, team = "Andmebaaside tiim" },
				new project { name = "Sõidupäevikud", start = new DateTime(2025, 1, 6).AddDays(322), Deadline = new DateTime(2025, 1, 6).AddDays(434), buget = 29500m, hourlyRate = 80m, team = "Mobiiliarenduse tiim" },
				new project { name = "Restorani tellimused", start = new DateTime(2025, 1, 6).AddDays(336), Deadline = new DateTime(2025, 1, 6).AddDays(462), buget = 13250m, hourlyRate = 55m, team = "Integratsioonide tiim" },
				new project { name = "Veebipoe maksed", start = new DateTime(2025, 1, 6).AddDays(350), Deadline = new DateTime(2025, 1, 6).AddDays(420), buget = 15750m, hourlyRate = 60m, team = "Ärianalüüsi tiim" },
				new project { name = "Tervisekeskuse kalender", start = new DateTime(2025, 1, 6).AddDays(364), Deadline = new DateTime(2025, 1, 6).AddDays(448), buget = 18250m, hourlyRate = 65m, team = "Testimise tiim" },
				new project { name = "Reisikulude arvestus", start = new DateTime(2025, 1, 6).AddDays(378), Deadline = new DateTime(2025, 1, 6).AddDays(476), buget = 20750m, hourlyRate = 70m, team = "Tootearenduse tiim" },
				new project { name = "Õppeinfosüsteem", start = new DateTime(2025, 1, 6).AddDays(392), Deadline = new DateTime(2025, 1, 6).AddDays(504), buget = 23250m, hourlyRate = 75m, team = "Veebiarenduse tiim" },
				new project { name = "Tootmise planeerija", start = new DateTime(2025, 1, 6).AddDays(406), Deadline = new DateTime(2025, 1, 6).AddDays(532), buget = 25750m, hourlyRate = 80m, team = "Andmebaaside tiim" },
				new project { name = "Turunduse haldus", start = new DateTime(2025, 1, 6).AddDays(420), Deadline = new DateTime(2025, 1, 6).AddDays(490), buget = 28250m, hourlyRate = 55m, team = "Mobiiliarenduse tiim" },
				new project { name = "Autopargi haldus", start = new DateTime(2025, 1, 6).AddDays(434), Deadline = new DateTime(2025, 1, 6).AddDays(518), buget = 30750m, hourlyRate = 60m, team = "Integratsioonide tiim" },
				new project { name = "Andmeladu", start = new DateTime(2025, 1, 6).AddDays(448), Deadline = new DateTime(2025, 1, 6).AddDays(546), buget = 14500m, hourlyRate = 65m, team = "Ärianalüüsi tiim" },
				new project { name = "Kliendirahulolu analüüs", start = new DateTime(2025, 1, 6).AddDays(462), Deadline = new DateTime(2025, 1, 6).AddDays(574), buget = 17000m, hourlyRate = 70m, team = "Testimise tiim" },
				new project { name = "Teeninduse järjekord", start = new DateTime(2025, 1, 6).AddDays(476), Deadline = new DateTime(2025, 1, 6).AddDays(602), buget = 19500m, hourlyRate = 75m, team = "Tootearenduse tiim" }
			};

			context.Set<project>().AddRange(projects);
			context.SaveChanges();
		}

		private static void SeedTasks(ApplicationDbContext context)
		{
			if (context.Set<task>().Any())
			{
				return;
			}

			var tasks = new List<task>
			{
				new task { title = "Kasutajate sisselogimise arendus", start = new DateTime(2025, 1, 6).AddDays(7), estimatedhours = 16m, responsiblePerson = "Mari Tamm", description = "Projekti 'Kliendiportaal' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 880m },
				new task { title = "Laoseisu arvutamise loogika", start = new DateTime(2025, 1, 6).AddDays(21), estimatedhours = 24m, responsiblePerson = "Jaan Kask", description = "Projekti 'Laoarvestus' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 1440m },
				new task { title = "Ostukorvi mobiilivaate loomine", start = new DateTime(2025, 1, 6).AddDays(35), estimatedhours = 32m, responsiblePerson = "Liis Saar", description = "Projekti 'E-poe mobiilivaade' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 2080m },
				new task { title = "Tööaja sisestamise vorm", start = new DateTime(2025, 1, 6).AddDays(49), estimatedhours = 40m, responsiblePerson = "Karl Mägi", description = "Projekti 'Tööajaarvestus' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 2800m },
				new task { title = "Koolitustele registreerimise vorm", start = new DateTime(2025, 1, 6).AddDays(63), estimatedhours = 48m, responsiblePerson = "Anna Pärn", description = "Projekti 'Koolituste portaal' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 3600m },
				new task { title = "Avalehe kujunduse uuendamine", start = new DateTime(2025, 1, 6).AddDays(77), estimatedhours = 56m, responsiblePerson = "Martin Sepp", description = "Projekti 'Veebilehe uuendus' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 4480m },
				new task { title = "PDF-arvete genereerimine", start = new DateTime(2025, 1, 6).AddDays(91), estimatedhours = 64m, responsiblePerson = "Kertu Kivi", description = "Projekti 'Arvete automaatika' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 3520m },
				new task { title = "Pöördumiste staatuste haldamine", start = new DateTime(2025, 1, 6).AddDays(105), estimatedhours = 16m, responsiblePerson = "Rasmus Vaher", description = "Projekti 'Klienditoe süsteem' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 960m },
				new task { title = "Töötajate profiilide loomine", start = new DateTime(2025, 1, 6).AddDays(119), estimatedhours = 24m, responsiblePerson = "Laura Kuusk", description = "Projekti 'Personaliportaal' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 1560m },
				new task { title = "Vabade aegade kalendri arendus", start = new DateTime(2025, 1, 6).AddDays(133), estimatedhours = 32m, responsiblePerson = "Markus Oja", description = "Projekti 'Broneerimisplatvorm' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 2240m },
				new task { title = "Ülesannete kanban-vaate loomine", start = new DateTime(2025, 1, 6).AddDays(147), estimatedhours = 40m, responsiblePerson = "Kristiina Ilves", description = "Projekti 'Projektide töölaud' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 3000m },
				new task { title = "Saadetiste oleku kuvamine", start = new DateTime(2025, 1, 6).AddDays(161), estimatedhours = 48m, responsiblePerson = "Andres Lepp", description = "Projekti 'Tarnete jälgimine' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 3840m },
				new task { title = "Dokumentide versioonihaldus", start = new DateTime(2025, 1, 6).AddDays(175), estimatedhours = 56m, responsiblePerson = "Grete Raud", description = "Projekti 'Dokumendihaldus' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 3080m },
				new task { title = "Tooteotsingu ja filtrite arendus", start = new DateTime(2025, 1, 6).AddDays(189), estimatedhours = 64m, responsiblePerson = "Mihkel Lill", description = "Projekti 'Tootekataloog' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 3840m },
				new task { title = "Küsitluste tulemuste kokkuvõte", start = new DateTime(2025, 1, 6).AddDays(203), estimatedhours = 16m, responsiblePerson = "Eliise Põld", description = "Projekti 'Küsitluste portaal' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 1040m },
				new task { title = "Müügigraafikute loomine", start = new DateTime(2025, 1, 6).AddDays(217), estimatedhours = 24m, responsiblePerson = "Siim Mets", description = "Projekti 'Müügiaruanded' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 1680m },
				new task { title = "Osalejate nimekirja haldamine", start = new DateTime(2025, 1, 6).AddDays(231), estimatedhours = 32m, responsiblePerson = "Triin Järv", description = "Projekti 'Ürituste haldus' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 2400m },
				new task { title = "Laenutuste tähtaja meeldetuletused", start = new DateTime(2025, 1, 6).AddDays(245), estimatedhours = 40m, responsiblePerson = "Kevin Toom", description = "Projekti 'Raamatukogu süsteem' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 3200m },
				new task { title = "Hoolduskalendri loomine", start = new DateTime(2025, 1, 6).AddDays(259), estimatedhours = 48m, responsiblePerson = "Sandra Sild", description = "Projekti 'Hooldustööde kalender' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 2640m },
				new task { title = "Raamatupidamise API ühendamine", start = new DateTime(2025, 1, 6).AddDays(273), estimatedhours = 56m, responsiblePerson = "Erik Rebane", description = "Projekti 'Raamatupidamise liides' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 3360m },
				new task { title = "Ribakoodilugeja ühendamine", start = new DateTime(2025, 1, 6).AddDays(287), estimatedhours = 64m, responsiblePerson = "Helena Kalda", description = "Projekti 'Inventuuri mobiiliäpp' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 4160m },
				new task { title = "Kinnisvara otsingufiltrid", start = new DateTime(2025, 1, 6).AddDays(301), estimatedhours = 16m, responsiblePerson = "Robin Aas", description = "Projekti 'Kinnisvaraportaal' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 1120m },
				new task { title = "Liikmemaksude jälgimine", start = new DateTime(2025, 1, 6).AddDays(315), estimatedhours = 24m, responsiblePerson = "Kadri Kukk", description = "Projekti 'Spordiklubi portaal' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 1800m },
				new task { title = "Läbisõitude sisestamise vorm", start = new DateTime(2025, 1, 6).AddDays(329), estimatedhours = 32m, responsiblePerson = "Taavi Rätsep", description = "Projekti 'Sõidupäevikud' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 2560m },
				new task { title = "Menüü ja tellimuse vaade", start = new DateTime(2025, 1, 6).AddDays(343), estimatedhours = 40m, responsiblePerson = "Merilin Koppel", description = "Projekti 'Restorani tellimused' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 2200m },
				new task { title = "Pangalingi testimine", start = new DateTime(2025, 1, 6).AddDays(357), estimatedhours = 48m, responsiblePerson = "Priit Hallik", description = "Projekti 'Veebipoe maksed' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 2880m },
				new task { title = "Vastuvõttude broneerimise moodul", start = new DateTime(2025, 1, 6).AddDays(371), estimatedhours = 56m, responsiblePerson = "Sofia Nurm", description = "Projekti 'Tervisekeskuse kalender' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 3640m },
				new task { title = "Kuludokumentide lisamine", start = new DateTime(2025, 1, 6).AddDays(385), estimatedhours = 64m, responsiblePerson = "Oliver Roos", description = "Projekti 'Reisikulude arvestus' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 4480m },
				new task { title = "Hinnete sisestamise vaade", start = new DateTime(2025, 1, 6).AddDays(399), estimatedhours = 16m, responsiblePerson = "Johanna Paju", description = "Projekti 'Õppeinfosüsteem' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 1200m },
				new task { title = "Tootmistellimuste ajastamine", start = new DateTime(2025, 1, 6).AddDays(413), estimatedhours = 24m, responsiblePerson = "Rainer Teder", description = "Projekti 'Tootmise planeerija' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 1920m },
				new task { title = "Kampaaniate tulemuste analüüs", start = new DateTime(2025, 1, 6).AddDays(427), estimatedhours = 32m, responsiblePerson = "Birgit Vool", description = "Projekti 'Turunduse haldus' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = true, FixedPrice = 1760m },
				new task { title = "Sõidukite hooldusajaloo vaade", start = new DateTime(2025, 1, 6).AddDays(441), estimatedhours = 40m, responsiblePerson = "Hendrik Aavik", description = "Projekti 'Autopargi haldus' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 2400m },
				new task { title = "Andmete laadimise automatiseerimine", start = new DateTime(2025, 1, 6).AddDays(455), estimatedhours = 48m, responsiblePerson = "Mirjam Kaar", description = "Projekti 'Andmeladu' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 3120m },
				new task { title = "Tagasiside koondaruande loomine", start = new DateTime(2025, 1, 6).AddDays(469), estimatedhours = 56m, responsiblePerson = "Artur Sokk", description = "Projekti 'Kliendirahulolu analüüs' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 3920m },
				new task { title = "Järjekorranumbrite haldamine", start = new DateTime(2025, 1, 6).AddDays(483), estimatedhours = 64m, responsiblePerson = "Evelin Rand", description = "Projekti 'Teeninduse järjekord' ülesanne. Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.", IsCompleted = false, FixedPrice = 4800m }
			};

			context.Set<task>().AddRange(tasks);
			context.SaveChanges();
		}

		private static void SeedLogs(ApplicationDbContext context)
		{
			if (context.Set<logs>().Any())
			{
				return;
			}

			var logEntries = new List<logs>
			{
				new logs { date = new DateTime(2025, 1, 6).AddDays(11), hours = 2m, worker = "Mari Tamm", description = "Projekti 'Kliendiportaal' töö: kasutajate sisselogimise arendus" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(25), hours = 3m, worker = "Jaan Kask", description = "Projekti 'Laoarvestus' töö: laoseisu arvutamise loogika" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(39), hours = 4m, worker = "Liis Saar", description = "Projekti 'E-poe mobiilivaade' töö: ostukorvi mobiilivaate loomine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(53), hours = 5m, worker = "Karl Mägi", description = "Projekti 'Tööajaarvestus' töö: tööaja sisestamise vorm" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(67), hours = 6m, worker = "Anna Pärn", description = "Projekti 'Koolituste portaal' töö: koolitustele registreerimise vorm" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(81), hours = 7m, worker = "Martin Sepp", description = "Projekti 'Veebilehe uuendus' töö: avalehe kujunduse uuendamine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(95), hours = 8m, worker = "Kertu Kivi", description = "Projekti 'Arvete automaatika' töö: pdf-arvete genereerimine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(109), hours = 2m, worker = "Rasmus Vaher", description = "Projekti 'Klienditoe süsteem' töö: pöördumiste staatuste haldamine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(123), hours = 3m, worker = "Laura Kuusk", description = "Projekti 'Personaliportaal' töö: töötajate profiilide loomine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(137), hours = 4m, worker = "Markus Oja", description = "Projekti 'Broneerimisplatvorm' töö: vabade aegade kalendri arendus" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(151), hours = 5m, worker = "Kristiina Ilves", description = "Projekti 'Projektide töölaud' töö: ülesannete kanban-vaate loomine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(165), hours = 6m, worker = "Andres Lepp", description = "Projekti 'Tarnete jälgimine' töö: saadetiste oleku kuvamine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(179), hours = 7m, worker = "Grete Raud", description = "Projekti 'Dokumendihaldus' töö: dokumentide versioonihaldus" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(193), hours = 8m, worker = "Mihkel Lill", description = "Projekti 'Tootekataloog' töö: tooteotsingu ja filtrite arendus" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(207), hours = 2m, worker = "Eliise Põld", description = "Projekti 'Küsitluste portaal' töö: küsitluste tulemuste kokkuvõte" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(221), hours = 3m, worker = "Siim Mets", description = "Projekti 'Müügiaruanded' töö: müügigraafikute loomine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(235), hours = 4m, worker = "Triin Järv", description = "Projekti 'Ürituste haldus' töö: osalejate nimekirja haldamine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(249), hours = 5m, worker = "Kevin Toom", description = "Projekti 'Raamatukogu süsteem' töö: laenutuste tähtaja meeldetuletused" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(263), hours = 6m, worker = "Sandra Sild", description = "Projekti 'Hooldustööde kalender' töö: hoolduskalendri loomine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(277), hours = 7m, worker = "Erik Rebane", description = "Projekti 'Raamatupidamise liides' töö: raamatupidamise api ühendamine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(291), hours = 8m, worker = "Helena Kalda", description = "Projekti 'Inventuuri mobiiliäpp' töö: ribakoodilugeja ühendamine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(305), hours = 2m, worker = "Robin Aas", description = "Projekti 'Kinnisvaraportaal' töö: kinnisvara otsingufiltrid" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(319), hours = 3m, worker = "Kadri Kukk", description = "Projekti 'Spordiklubi portaal' töö: liikmemaksude jälgimine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(333), hours = 4m, worker = "Taavi Rätsep", description = "Projekti 'Sõidupäevikud' töö: läbisõitude sisestamise vorm" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(347), hours = 5m, worker = "Merilin Koppel", description = "Projekti 'Restorani tellimused' töö: menüü ja tellimuse vaade" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(361), hours = 6m, worker = "Priit Hallik", description = "Projekti 'Veebipoe maksed' töö: pangalingi testimine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(375), hours = 7m, worker = "Sofia Nurm", description = "Projekti 'Tervisekeskuse kalender' töö: vastuvõttude broneerimise moodul" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(389), hours = 8m, worker = "Oliver Roos", description = "Projekti 'Reisikulude arvestus' töö: kuludokumentide lisamine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(403), hours = 2m, worker = "Johanna Paju", description = "Projekti 'Õppeinfosüsteem' töö: hinnete sisestamise vaade" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(417), hours = 3m, worker = "Rainer Teder", description = "Projekti 'Tootmise planeerija' töö: tootmistellimuste ajastamine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(431), hours = 4m, worker = "Birgit Vool", description = "Projekti 'Turunduse haldus' töö: kampaaniate tulemuste analüüs" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(445), hours = 5m, worker = "Hendrik Aavik", description = "Projekti 'Autopargi haldus' töö: sõidukite hooldusajaloo vaade" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(459), hours = 6m, worker = "Mirjam Kaar", description = "Projekti 'Andmeladu' töö: andmete laadimise automatiseerimine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(473), hours = 7m, worker = "Artur Sokk", description = "Projekti 'Kliendirahulolu analüüs' töö: tagasiside koondaruande loomine" },
				new logs { date = new DateTime(2025, 1, 6).AddDays(487), hours = 8m, worker = "Evelin Rand", description = "Projekti 'Teeninduse järjekord' töö: järjekorranumbrite haldamine" }
			};

			context.Set<logs>().AddRange(logEntries);
			context.SaveChanges();
		}

	}
}
