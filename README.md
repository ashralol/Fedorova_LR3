# ЛР 3. Авторизация и переход к формам по роли

Студент: Fedorova

Windows Forms (.NET Framework 4.7.2) + Entity Framework 6 (Code First из БД `User_Data`, таблицы Users и Roles).
Форма `FormAutorization` проверяет логин и пароль и открывает форму по роли:
1 — `FormManager`, 2 — `FormSeller`, 3 — `FormDirector`. Все три унаследованы от `FormParent`
(кнопка «Назад», имя, роль и фото пользователя).

Тестовые входы: log1/pas1 (Manager), log2/pas2 (Seller), log3/pas3 (Director).

Запуск:
1. Выполнить `User_Data.sql` в SQL Server (экземпляр `.\SQLEXPRESS`).
2. Открыть `Fedorova.sln` в Visual Studio 2022.
3. Папка `Photo` копируется в `bin\Debug` автоматически при сборке.
