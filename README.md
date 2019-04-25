# ReCourt Converter - Konwerter protokołów audio oraz wideo z rozpraw sądowych. 

Polski system sądownictwa przyjął system rejestrowania protokołów w postaci audio albo w postaci audiowizualnej w otwartych formatach, tj.
Speex dla audio (w kontenerze .OGA) oraz Speex + OGG Video (w kontenerze .OGV). Program jest prostą implementacją ffMPEG oraz biblioteki
C# NReco Video Converter pozwalającą na konwersję ww. formatów do bardziej rozpowszechnionych, tj. MP3, AAC, WAV, AC3. 

Program będzie jeszcze rozwijany i jest bardzo prosty w użyciu. Wystarczy otworzyć plik i następnie wybrać format, wskazać miejsce zapisu
i nazwać plik wynikowy. Program natychmiast konwertuje plik do wskazanej lokalizacji. Program ma automatyczny filtr otwierania pliku do wskazania, czy jest to protokół audio, czy też audio-wideo (wkrótce). Protokoły są dystrybuowane stronom postępowania na wniosek z darmowym programem ReCourt Player, stąd też nazwa ReCourt Converter.

System rejestracji posiada też bardzo przydatną, aczkolwiek chyba nigdzie nie wykorzystywaną funkcję. Mianowicie kontener .OGA (i OGG w ogólności) ma pełne możliwości do rejestracji odrębnych ścieżek dla każdego rozmówcy na sali sądowej (Sędzia, pełnomocnik, strona, świadek itd.), jednakże z przyczyn technicznych i dla uproszczenia, ścieżki są miksowane do jednego pliku, co czasami powoduje trudność w odsłuchaniu przekrzykujących się stron.

Program jest dedykowany dla profesjonalnych pełnomocników, którzy czasami mają potrzebę odsłuchania protokołu albo samodzielnie (.OGA jest egzotycznym kontenerem, jak i format Speex więc jest niewygodny w odsłuchiwaniu / archiwizacji bez ReCourt Player, który jest dostępny jedynie na Windowsa) albo przesłania nagrania Klientom na ich życzenie. Program ten rozwiązuje problem. 

Na chwilę obecną działa tylko konwersja do MP3, ale to tylko kwestia czasu i paru commitów, żeby napisać kolejne funkcje + video.

# Biblioteki

Do działania wymagana jest biblioteka NReco.Video.Converter dostępna w package managerze.

# Używanie

Wystarczy zaimportować sln wraz z biblioteką do VisualStudio.
