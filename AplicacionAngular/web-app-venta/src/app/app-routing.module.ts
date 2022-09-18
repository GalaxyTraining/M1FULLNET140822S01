import { Injectable, NgModule } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { RouterModule, RouterStateSnapshot, Routes, TitleStrategy } from '@angular/router';

const routes: Routes = [{path:'',redirectTo:'mfacade',pathMatch:'full'},
{path:'mfacade',loadChildren:()=>import('./facade/facade.module').then(m=>m.FacadeModule)},
{ path: '**', redirectTo: 'mfacade' }
];

// @Injectable()
// export class TemplatePageTitleStrategy extends TitleStrategy {
//   constructor(private readonly title: Title) {
//     super();
//   }

//   override updateTitle(routerState: RouterStateSnapshot) {
//     const title = this.buildTitle(routerState);
//     if (title !== undefined) {
//       this.title.setTitle(`Aplicacion venta - ${title}`);
//     }
//   }
// }


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
 // providers: [{provide: TitleStrategy,  useClass: TemplatePageTitleStrategy}]
})
export class AppRoutingModule { }
