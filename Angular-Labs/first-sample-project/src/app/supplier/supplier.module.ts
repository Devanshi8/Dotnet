import { CommonModule } from "@angular/common";
import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { SupplierRoutes } from "../routing/routing.supplier";
import { SupplierComponent } from "./supplier.component";

@NgModule({
    declarations: [
      SupplierComponent
    ],
    imports: [
      CommonModule,
      FormsModule,
      HttpClientModule,
      RouterModule.forChild(SupplierRoutes)
    ],
    providers: [],
    bootstrap: [SupplierComponent]
  })
  export class SupplierModule { }