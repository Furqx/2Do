CREATE TABLE todos (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    title TEXT NOT NULL,
    deadline TEXT NOT NULL,
    done TEXT NOT NULL,
    date TEXT NOT NULL
);

INSERT INTO todos
    (title, deadline, done, date)
VALUES
    ("Title", "Deadline", "done", "date"),
