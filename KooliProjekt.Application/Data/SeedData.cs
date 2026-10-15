using System;
using System.Collections.Generic;
using System.Linq;

namespace KooliProjekt.Application.Data
{
	public static class SeedData
	{
		private const int MinimumRows = 35;

		private static readonly string[] Names =
		{
			"Mari Tamm", "Jaan Kask", "Liis Saar", "Karl Mägi", "Anna Pärn",
			"Martin Sepp", "Kertu Kivi", "Rasmus Vaher", "Laura Kuusk", "Markus Oja",
			"Kristiina Ilves", "Andres Lepp", "Grete Raud", "Mihkel Lill", "Eliise Põld",
			"Siim Mets", "Triin Järv", "Kevin Toom", "Sandra Sild", "Erik Rebane",
			"Helena Kalda", "Robin Aas", "Kadri Kukk", "Taavi Rätsep", "Merilin Koppel",
			"Priit Hallik", "Sofia Nurm", "Oliver Roos", "Johanna Paju", "Rainer Teder",
			"Birgit Vool", "Hendrik Aavik", "Mirjam Kaar", "Artur Sokk", "Evelin Rand"
		};

		private static readonly string[] ProjectNames =
		{
			"Kliendiportaal",
			"Laoarvestus",
			"E-poe mobiilivaade",
			"Tööajaarvestus",
			"Koolituste portaal",
			"Veebilehe uuendus",
			"Arvete automaatika",
			"Klienditoe süsteem",
			"Personaliportaal",
			"Broneerimisplatvorm",
			"Projektide töölaud",
			"Tarnete jälgimine",
			"Dokumendihaldus",
			"Tootekataloog",
			"Küsitluste portaal",
			"Müügiaruanded",
			"Ürituste haldus",
			"Raamatukogu süsteem",
			"Hooldustööde kalender",
			"Raamatupidamise liides",
			"Inventuuri mobiiliäpp",
			"Kinnisvaraportaal",
			"Spordiklubi portaal",
			"Sõidupäevikud",
			"Restorani tellimused",
			"Veebipoe maksed",
			"Tervisekeskuse kalender",
			"Reisikulude arvestus",
			"Õppeinfosüsteem",
			"Tootmise planeerija",
			"Turunduse haldus",
			"Autopargi haldus",
			"Andmeladu",
			"Kliendirahulolu analüüs",
			"Teeninduse järjekord"
		};

		private static readonly string[] TaskTitles =
		{
			"Kasutajate sisselogimise arendus",
			"Laoseisu arvutamise loogika",
			"Ostukorvi mobiilivaate loomine",
			"Tööaja sisestamise vorm",
			"Koolitustele registreerimise vorm",
			"Avalehe kujunduse uuendamine",
			"PDF-arvete genereerimine",
			"Pöördumiste staatuste haldamine",
			"Töötajate profiilide loomine",
			"Vabade aegade kalendri arendus",
			"Ülesannete kanban-vaate loomine",
			"Saadetiste oleku kuvamine",
			"Dokumentide versioonihaldus",
			"Tooteotsingu ja filtrite arendus",
			"Küsitluste tulemuste kokkuvõte",
			"Müügigraafikute loomine",
			"Osalejate nimekirja haldamine",
			"Laenutuste tähtaja meeldetuletused",
			"Hoolduskalendri loomine",
			"Raamatupidamise API ühendamine",
			"Ribakoodilugeja ühendamine",
			"Kinnisvara otsingufiltrid",
			"Liikmemaksude jälgimine",
			"Läbisõitude sisestamise vorm",
			"Menüü ja tellimuse vaade",
			"Pangalingi testimine",
			"Vastuvõttude broneerimise moodul",
			"Kuludokumentide lisamine",
			"Hinnete sisestamise vaade",
			"Tootmistellimuste ajastamine",
			"Kampaaniate tulemuste analüüs",
			"Sõidukite hooldusajaloo vaade",
			"Andmete laadimise automatiseerimine",
			"Tagasiside koondaruande loomine",
			"Järjekorranumbrite haldamine"
		};

		private static readonly string[] Teams =
		{
			"Veebiarenduse tiim", "Andmebaaside tiim", "Mobiiliarenduse tiim",
			"Integratsioonide tiim", "Ärianalüüsi tiim", "Testimise tiim",
			"Tootearenduse tiim"
		};

		public static void Generate(ApplicationDbContext context)
		{
			SeedUsers(context);
			SeedProjects(context);
			SeedTasks(context);
			SeedLogs(context);
		}

		private static void SeedUsers(ApplicationDbContext context)
		{
			var users = new List<user>();

			for (int i = 0; i < MinimumRows; i++)
			{
				users.Add(new user
				{
					name = Names[i],
					email = MakeEmail(Names[i]),
					password = $"DemoPass!2026-{i + 1:00}"
				});
			}

			AddMissing(context, users, item => item.email);
		}

		private static void SeedProjects(ApplicationDbContext context)
		{
			var projects = new List<project>();
			var firstMonday = new DateTime(2025, 1, 6, 9, 0, 0);

			for (int i = 0; i < MinimumRows; i++)
			{
				DateTime startDate = firstMonday.AddDays(i * 14);

				projects.Add(new project
				{
					name = ProjectNames[i],
					start = startDate,
					Deadline = startDate.AddDays(70 + (i % 5) * 14),
					buget = 9500m + (i % 8) * 2500m + (i / 8) * 1250m,
					hourlyRate = 55m + (i % 6) * 5m,
					team = Teams[i % Teams.Length]
				});
			}

			AddMissing(context, projects, item => item.name);
		}

		private static void SeedTasks(ApplicationDbContext context)
		{
			var tasks = new List<task>();
			var firstMonday = new DateTime(2025, 1, 6, 9, 0, 0);

			for (int i = 0; i < MinimumRows; i++)
			{
				decimal estimatedHours = 16m + (i % 7) * 8m;
				decimal hourlyRate = 55m + (i % 6) * 5m;

				tasks.Add(new task
				{
					title = TaskTitles[i],
					start = firstMonday.AddDays(i * 14 + 7),
					estimatedhours = estimatedHours,
					responsiblePerson = Names[i],
					description = $"Projekti '{ProjectNames[i]}' ülesanne. " +
								  "Töö sisaldab arendust, kontrollimist ja tulemuse üleandmist.",
					IsCompleted = i < 22 || i % 6 == 0,
					FixedPrice = estimatedHours * hourlyRate
				});
			}

			AddMissing(context, tasks, item => item.title);
		}

		private static void SeedLogs(ApplicationDbContext context)
		{
			var logs = new List<logs>();
			var firstMonday = new DateTime(2025, 1, 6, 9, 0, 0);

			for (int i = 0; i < MinimumRows; i++)
			{
				logs.Add(new logs
				{
					date = firstMonday.AddDays(i * 14 + 11),
					hours = 2m + (i % 7),
					worker = Names[i],
					description = $"Projekti '{ProjectNames[i]}' töö: " + TaskTitles[i].ToLowerInvariant()
				});
			}

			AddMissing(context, logs, item => item.description);
		}

		// Lisab igasse tabelisse puuduolevad read, kuni seal on vähemalt 35 kirjet.
		// Kontrollib olemasolevaid võtmeid, et korduv käivitamine ei looks duplikaate.
		private static void AddMissing<TEntity>(
			ApplicationDbContext context,
			List<TEntity> candidates,
			Func<TEntity, string> getKey) where TEntity : class
		{
			var table = context.Set<TEntity>();
			int missing = MinimumRows - table.Count();

			if (missing <= 0)
			{
				return;
			}

			var existingKeys = new HashSet<string>(
				table.AsEnumerable().Select(getKey),
				StringComparer.OrdinalIgnoreCase);

			var newRows = candidates
				.Where(item => !existingKeys.Contains(getKey(item)))
				.Take(missing)
				.ToList();

			table.AddRange(newRows);
			context.SaveChanges();
		}

		private static string MakeEmail(string fullName)
		{
			return fullName.ToLowerInvariant()
				.Replace('ä', 'a')
				.Replace('ö', 'o')
				.Replace('ü', 'u')
				.Replace('õ', 'o')
				.Replace(' ', '.') + "@example.com";
		}
	}
}
