# AppsForVC-NN_Open
Compiled and source resources for educational BIM project in Nizhny Novgorod
## AnalyzeFinishFolder - приложение для анализа вложенных файлов для Итоговой котрольной точки
### Принипы использования
1. Загружаем приложение из репозитория [по ссылке](https://github.com/GeorgGrebenyuk/AppsForVC-NN_Open/raw/main/AnalyzeFinishFolder/bin/Debug/AnalyzeFinishFolder.exe)
После запуска приложение будет выгядеть ![примерно так:](/images/Screen1.png)
2. Нажимаем на кнопку "Обзор" и [выбираем папку "Исходящие" в вашей папке участка](/images/Screen2.png)
3. После выборе нажимаем на кнопку "Запуск" для старта процедуры анализа. По окончанию, в табличной форме ниже (элемент WInForms DataGridView) будет представлен [результат проверки:](/images/Screen3.png)
4. Далее необходимо проанализировать список и устранить все ошибки связанные с сигнатурой False и наличием какого-либо комментария (при успешной проверке никаких комментариев быть не должно, а все сигнатуры должны иметь статус "True")

