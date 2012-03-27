mysql> CREATE DATABASE AspMvc_Mysql_test;
mysql> USE AspMvc_Mysql_test;

// connection string "DRIVER={MySQL ODBC 3.51 Driver};Database=AspMvc_Mysql_test;Server=localhost;UID=root;PWD=123;"
// providerName="MySql.Data.MySqlClient"

<connectionStrings>
    <add name="ApplicationServices"
         connectionString="data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|aspnetdb.mdf;User Instance=true"
         providerName="System.Data.SqlClient" 
         />
    <add name="MysqlContext" 
         connectionString="Database=AspMvc_Mysql_test;Server=localhost;UID=root;PWD=123;"
         providerName="MySql.Data.MySqlClient"
         />
  </connectionStrings>

  // do not do this!  
  <system.data>
    <DbProviderFactories>
      <add name="MySQL Data Provider" 
           invariant="MySql.Data.MySqlClient" 
           description=".Net Framework Data Provider for MySQL" 
           type="MySql.Data.MySqlClient.MySqlClientFactory, MySql.Data, Version=5.2.7.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d"/>
    </DbProviderFactories>
  </system.data>


TODO:
http://dev.mysql.com/doc/refman/5.1/en/connector-net-visual-studio.html
