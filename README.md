Progetto model view controller (mvc) creato da cmd.
sito asp.net che prevede la registrazione di un utente tramite una form che chiede l'inserimento di alcuni dati tra cui Id, Nome, Cognome,Enail, Città, Tipo.
Per realizare abbiamo creato all' interno della cartella Models un file Utente.cs in cui vengono richiesti i campi.
Nella cartella Controller troviamo un file HomeController.cs in cui sono specificate le Action che ci permettono di ritornare una view.
Poichè è necessario visuallizare l'elenco degli utenti registrati, le registrazioni vengono salvate su un database. 
é necessario quindi realizzare un database e poi aggiungere in models un file database.cs che per aggiungere gli utenti al db.
A questo punto vanno aggiunte al progetto librerie di Entity Framework, SQLIte e Identity.
Verifichiamo la versione di dotnet installata tramite il comando dotnet --version e una volta visualizzara la versione installata aggoiungiamo i pacchetti relativi alla versione. 

    dotnet add package Microsoft.EntityFrameworkCore -v 7.0.0 // in questo caso la versione di dotnet installata è la 7.0.0
    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore  -v 7.0.0
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite -v 7.0.0
    dotnet add package Microsoft.EntityFrameworkCore.Design -v 7.0.0

Vanno aggiunti i tool necessari.

    dotnet tool search ef // per visualizzare i tool installati 
    dotnet ef --version // per la versione 
    dotnet tool update --global dotnet-ef // per aggiornare i tool

infine si verifica che i tool siano installati vedendo il logo di ef. 
    
    dotnet-ef // dovrebbe comparire il logo di ef e l' unicorno

Si crea il database, dopo  aver definito il database in database.cs, si eseguoni i seguenti comandi:
- dotnet ef migrations add "Primaversionedeldb"
- dotnet ef database update 
