# Database

## Пользователи:

```sql
CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    role VARCHAR(50) NOT NULL
);
```
## Заявки:
```sql
CREATE TABLE requests (
    id SERIAL PRIMARY KEY,
    request_number VARCHAR(50) UNIQUE NOT NULL,
    date_added TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    client_name VARCHAR(255) NOT NULL,
    destination VARCHAR(255) NOT NULL,
    documents TEXT,
    tour_type VARCHAR(50),
    client_count INTEGER,
    status VARCHAR(50)
);
```


