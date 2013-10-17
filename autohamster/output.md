Дайджест полезных ссылок для тестировщиков-автоматизаторов #006 

<img src="http://automated-testing.info/uploads/default/16/e7ca841252bf0e41.png" width="529" height="136">

### Интересное на AT.Info
* [[Заметка] Сохранение переменных, передаваемых в Jmeter, в отдельный файл](http://automated-testing.info/t/zametka-soxranenie-peremennyx-peredavaemyx-v-jmeter-v-otdelnyj-fajl/3543) (Прислал(-а): @DmitriyZverev) <br><small><font color="gray">Java</font></small><br>Обычно те, кто использует Jmeter, реализуют обратную задачу: загружают переменные в Jemet из файла. Я же столкнулся с другой проблемой: подготовка данных для теста и сам запуск Jmeter производились во внешнем фреймворке. Данных и тестов было так много, что бывало сложно уследить не потерял ли я что-то или правильно ли они сформировались.<br><br>
* [ [Заметка] [C#] WebDriverWait и PageObject](http://automated-testing.info/t/zametka-c-webdriverwait-i-pageobject/3531) (Прислал(-а): @dzhariy) <br><small><font color="gray">Автоматизация тестирования, C#, WebDriver</font></small><br>Казалось бы, реализация PageObjects и WebDriverWait находятся очень близко друг к другу, прямо в соседних пространствах имен, соответственно...<br><br>
* [ [Заметка] [C#] Атрибут [FindsBy] в PageObject? – Дайте два!](http://automated-testing.info/t/zametka-c-atribut-findsby-v-pageobject-dajte-dva/3526) (Прислал(-а): @dzhariy) <br><small><font color="gray">C#, WebDriver</font></small><br>При прогоне тестов на Selenium WebDriver в разных браузерах, иногда бывают такие мистические проблемы, что локаторы, которые работают в Internet Explorer и Chrome… почему-то перестают работать в PhantomJS, и при этом не всегда, а в момент перехода между страницами…<br><br>
* [ [Заметка] Автоматическое создание Браузера и инициализация PageObject](http://automated-testing.info/t/zametka-avtomaticheskoe-sozdanie-brauzera-i-iniczializacziya-pageobject/3522) (Прислал(-а): @dzhariy) <br><small><font color="gray">Автоматизация тестирования, Java, C#, WebDriver</font></small><br>Многих людей, хлебом не корми – дай только пописать лишний код, да и передать лишний вебдрайвер каждому ПейджОбжекту в самый конструктор… В примере ниже, я покажу, как избежать лишних явных созданий экземпляра вебдрайвера и лишних инициализаций PageFactory.InitElements<br><br>


### Статьи по автоматизации тестирования
* [Что такое browsermob-proxy и как заставить его работать? Туториал для начинающих. Пример использования на Python](http://automated-testing.info/t/chto-takoe-browsermob-proxy-i-kak-zastavit-ego-rabotat-tutorial-dlya-nachinayushhix-primer-ispolzovaniya-na-python/3510) (Прислал(-а): @polusok) <br><small><font color="gray">Автоматизация тестирования, Python, WebDriver</font></small><br>Что такое browsermob-proxy? Это отдельный инструмент\библиотека, которая запускает прокси сервер и собирает данные, которые прошли через этот прокси сервер для последующей обработки в формате json. Формат данных еще называется HAR - HTTP Archive Specification. В пособие описано, как начать работать с этим инструментом.<br><br>
* [Библиотека расширенного логирования для RobotFramework](http://automated-testing.info/t/zametka-biblioteka-rasshirennogo-logirovaniya-dlya-robotframework/3506) (Прислал(-а): @polusok) <br><small><font color="gray">Python, RobotFramework</font></small><br>С RobotFramework-ом очень удобно работать, но иногда необходимо сделать свое логирование. Как его можно сделать в RobotFramework? Рассмотрен пример и деталями кода на Python<br><br>
* [Как считать емейл по imap c mail.ru в Python? Или что такое quoted printable encoding?](http://automated-testing.info/t/zametka-kak-schitat-emejl-po-imap-c-mail-ru-v-python-ili-chto-takoe-quoted-printable-encoding/3494) (Прислал(-а): @polusok) <br><small><font color="gray">Python</font></small><br>Если Вы хоть когда-то считывали сообщения по imap4 протоколу, то наверное знаете, что ничего сложного в этом нет, а тем более если вы умеете программировать на Python. Но иногда появляются танцы с бубнами, когда встречается русские символы. В заметке рассмотрено, как бороться с такой кодировкой при чтении емейлов с mail.ru.<br><br>
* [Как быстрее проверять автотесты во время их разработки](http://positiveflower.blogspot.com/2013/10/blog-post.html)  <br><small><font color="gray">Автоматизация тестирования, C#</font></small><br>Ни для кого не секрет, что процесс выполнения UI автотестов не очень быстрый. А во время создания автотеста часто приходится запускать его на выполнение несколько раз и ждать, пока он пройдет. В целях экономии времени я использую несколько способов для сокращения времени проверки работоспособности теста во время его создания, о которых и хочу рассказать. Все примеры взяты из моего опыта, надеюсь, что-то будет полезно.<br><br>
* [Tips to Avoid Brittle UI Tests](http://net.tutsplus.com/tutorials/tools-and-tips/tips-to-avoid-brittle-ui-tests/) (Прислал(-а): @dzhariy) <br><small><font color="gray">Код, Java, C#, WebDriver</font></small><br>Свежее руководство о том, что нужно сделать для того, чтобы тесты на Selenium WebDriver не ломались. Все самое лучшее с примерами на C# и Java<br><br>


### Инструменты
* [Sitechco](http://sitechco.ru) (Прислал(-а): @TITnet) <br><small><font color="gray">Работы с чек-листами</font></small><br>Бесплатный SAAS для работы с чек-листами.<br><br>


### Слайды, презентации по автоматизации тестирования
* [Building Continuous Delivery - DevOps Way](https://speakerdeck.com/andrebrov/building-continuous-delivery-devops-way) (Прислал(-а): @dzhariy) <br><small><font color="gray">Автоматизация тестирования</font></small><br>И несколько советов по выбору  пути автоматизированного разворачивания продукта <br><br>


---------------
**Не хотите пропускать ничего интересного?** 
Подпишитесь на ленту [RSS Новости]( http://automated-testing.info/category/novosti.rss)  

И еще, **хотите добавить ссылку** в следующий дайджест?<br>
Тогда – **[сделайте это через специальную форму!](http://goo.gl/p8JpCx)** (Это – просто)   

---------
Смотрите также: [(Анонс) Automated Hamster: Ссылки для Автоматизаторов](http://automated-testing.info/t/anons-automated-hamster-ssylki-dlya-avtomatizatorov/3399)
