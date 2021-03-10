# RAS.ASPNET_MVC_CORE


- FluentAPI - Mapping Entities
- To create migeation:
    Add-Migration Initial -Verbose -Context BookShopDbContext
    
- To create script migration
    Script-Migration -Context BookShopDbContext
    Script-Migration -Context ApplicationDbContext
    
- To Create Database Tables
   Update-Database -Context ApplicationDbContext
   Update-Database -Context BookShopDbContext
