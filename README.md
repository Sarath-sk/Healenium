
# Healenium

Healenium is an open-source library for automated testing that leverages the power of machine learning to improve the reliability and resilience of your tests.

## Installation
Healenium Proxy without Docker.
### Requirements:
* Java 8+
* Python
* PostgerSQL
Install PostgreSQL: https://www.postgresql.org/download/

After successful installation, you need to prepare the database for Healenium services using psql:

#### 1.1. Create database and user
```bash
CREATE DATABASE healenium;
CREATE USER healenium_user WITH ENCRYPTED PASSWORD 'YDk2nmNs4s9aCP6K';
GRANT ALL PRIVILEGES ON DATABASE healenium TO healenium_user;
ALTER USER healenium_user WITH SUPERUSER;
\c healenium healenium_user;
```
#### 1.2. Create schema
```bash
CREATE SCHEMA healenium AUTHORIZATION healenium_user;
GRANT USAGE ON SCHEMA healenium TO healenium_user;
```

Selenium server. Documentation [here](https://www.selenium.dev/documentation/grid/getting_started/).
As example:

- Download selenium-server jar: 4.5.0
- Run as standalone mode:
```bash
java -jar selenium-server-4.5.0.jar standalone
```


#### Install Healenium without Docker
&nbsp; 1. [Download latest version](https://github.com/healenium/healenium/releases/) or clone Healenium repository:
Structure of archive:

/shell-installation/ - directory for install Healenium without docker. It contains /selenium-grid (for Healenium-Proxy) and /web (for Healenium-Web) directories

&nbsp;2. Go to /shell-installation/selenium-grid

&nbsp;3. Download Healenium components. Run download_services.sh

&nbsp;4. Run start_healenium.sh

&nbsp;Navigate to http://<hlm-backend-address>/healenium/report to check healenium backend is running.
Locally: http://localhost:7878/healenium/report

&nbsp;5. Init driver instance of RemoteWebDriver

Create a RemoteWebDriver with the address of the Healenium-Proxy server. Example in C#.
```bash
String nodeURL = "http://localhost:8085";

ChromeOptions optionsChrome = new ChromeOptions();
optionsChrome.AddArguments("--no-sandbox");
    
RemoteWebDriver driverChrome = new RemoteWebDriver(new Uri(nodeURL), optionsChrome);

```

Refer official documentation for latest installation steps [here](https://healenium.io/docs/download_and_install/hlm_proxy#!/tab/586014895-4).


## Authors

- [@Sarath-sk](https://github.com/Sarath-sk)


## Demo


https://drive.google.com/file/d/1Ne5wl-hU_Pb4lIbP6u-dg9SBsMSb_aEe/view?usp=drive_link
