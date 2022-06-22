
import { AdminComponent } from "../admin/admin.component";
import { HomeComponent } from "../home/home.component";
import { UserComponent } from "../user/user.component";
import { ProductComponent } from "../product/product.component";


export const MainRoutes= [
   {path:'',component:HomeComponent},
    {path:'home',component:HomeComponent},
    {path:'admin',loadChildren:()=>import('../admin/admin.module').then(m=>m.AdminModule)},
    {path:'user',loadChildren:()=>import('../user/user.module').then(m=>m.UserModule)},
    {path:'admin',loadChildren:()=>import('../admin/admin.module').then(m=>m.AdminModule)},
    {path:'product',loadChildren:()=>import('../product/product.module').then(m=>m.ProductModule)},
  
   
];