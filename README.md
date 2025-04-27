# Descriere generală a proiectului
Virtual Pet Simulator este o aplicație de tip Windows Forms (WinForms), care permite utilizatorului să îngrijească un animal virtual (câine sau pisică).

Utilizatorul poate să:
  - Hrănească animalul;
  - Se joace cu animalul;
  - Pună animalul să doarmă.

Aplicația oferă un UI interactiv, cu:
  - Progress bars pentru energie, fericire și foame;
  - Imagini dinamice în funcție de starea animalului;
  - Selectare mod de joacă (Gentle/Intense).

# Structura generală a proiectului
Proiectul are următoarea structură de foldere și clase:

    VirtualPetSimulator/
    ├── Form1.cs                --> Interfața principală (UI)
    ├── Models/
    │   ├── Pet.cs              --> Clasa abstractă pentru animale
    │   ├── Dog.cs              --> Câinele (derivă din Pet)
    │   └── Cat.cs              --> Pisica (derivă din Pet)
    ├── Behaviors/
    │   ├── IPlayBehavior.cs    --> Interfață pentru comportamentul de joacă
    │   ├── PlayGentle.cs       --> Implementare joacă ușoară
    │   └── PlayIntense.cs      --> Implementare joacă intensă
    ├── Observers/
    │   ├── IPetObserver.cs     --> Interfață Observer
    │   └── ConsolePetObserver.cs --> Implementare Observer (log în consolă)
    TestVirtualPetSimulator/
    ├── PetTests.cs             --> Unit Teste


# Tehnologii utilizate 
1. Programare Orientată pe Obiecte (OOP)
   - Clase abstracte: Pet este abstract pentru că vrem să forțăm toate animalele să aibă comportamente de bază (Feed, Play, Sleep), dar să le poată implementa diferit.

    - Moștenire: Dog și Cat moștenesc Pet.

    - Interfețe: IPlayBehavior și IPetObserver definesc contracte clare de comportament, fără să forțăm o implementare fixă.

2. Design Patterns
   
    • Strategy Pattern (IPlayBehavior):

       - Permite alegerea dinamică a comportamentului de joacă (gentle sau intense).

       - Exemplu: câinele poate să se joace intens sau ușor, fără să modifici clasa Dog.

    • Observer Pattern (IPetObserver + ConsolePetObserver):

       - Permite notificarea automată a observatorilor atunci când starea animalului se schimbă.

        - Exemplu: consola poate afișa mesaj când animalul devine foarte flămând sau foarte fericit.

# Interfața grafică (Form1)
 • Timer: scade automat fericirea în timp.

 • PictureBox: imaginea animalului se schimbă în funcție de starea lui.

 • Radio Buttons: selectează tipul animalului (câine sau pisică).

 • ComboBox: selectează tipul de joacă (gentle sau intense).

 • Progress Bars: arată vizual nivelul de foame, energie și fericire.

# Unit Testări
Am creat 3 teste unitare în TestVirtualPetSimulator folosind MSTest.

Testele acoperă:

    Test                         | Ce verifică?                             | Gândire din spate
    TestPlayIncreasesHappiness   | Fericirea animalului crește după joacă   | Asigurăm că Play afectează Happiness corect
    TestFeedDecreasesHunger      | Foamea scade după hrănire                | Confirmăm că Feed funcționează
    TestSleepRestoresEnergy      | Energia crește după somn                 | Verificăm logica Sleep

__Observații:__
La TestPlayIncreasesHappiness este nevoie să se seteze PlayBehavior manual în test, pentru că în aplicație este setat prin interfață și aici lipsea inițial.

# Diagrame explicative

![image](https://github.com/user-attachments/assets/0cc82671-5da8-4dc6-ba29-3438820d88eb)

# Demo

https://github.com/user-attachments/assets/b912590d-a29c-481f-b54c-45c828f8a300

# Webografie

1. [Microsoft Docs - Windows Forms Overview](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-8.0)

2. [Refactoring.Guru - Design Patterns](https://refactoring.guru/design-patterns)

3. [NUnit Documentation](https://nunit.org/)

4. [GitHub Docs - Mastering Markdown](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)

5. [PlantUML Documentation](https://www.codeguru.com/csharp/solid-principles-in-c-sharp/)
