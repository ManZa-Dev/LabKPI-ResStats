using Serenity.Navigation;

[assembly: NavigationMenu(10000, "Statistiche", icon: "fas fa-chart-bar")]
[assembly: NavigationLink(10001, "Statistiche/Risultati Analisi", url: "~/risultati", permission: "", icon: "fas fa-calculator")]
[assembly: NavigationLink(10002, "Statistiche/Tabelle (alpha)", url: "~/tabella", permission: "", icon: "fas fa-signal")]

