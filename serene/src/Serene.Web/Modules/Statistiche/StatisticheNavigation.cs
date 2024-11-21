using Serenity.Navigation;

[assembly: NavigationMenu(7850, "Statistiche", icon: "fas fa-chart-bar")]
[assembly: NavigationLink(7851, "Statistiche/Risultati Analisi", url: "~/risultati", permission: "", icon: "fas fa-calculator")]
[assembly: NavigationLink(7852, "Statistiche/Tabelle (alpha)", url: "~/tabella", permission: "", icon: "fas fa-sort")]

// Modifica: Antonio Manzara -> 21/11/2024
// Ho Cambiato le icone per non fare confusione in fase di test
// Ho cambiato la priorità a 7850 per non far finire il menù statistiche sotto le ultime due voci
// 10000+ per metterlo alla fine
// 1-999 per metterlo prima di Dashboard