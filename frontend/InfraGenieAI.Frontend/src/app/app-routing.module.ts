import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CicdGeneratorComponent } from './cicd-generator/cicd-generator.component';

const routes: Routes = [
  { path: '', redirectTo: 'generate', pathMatch: 'full' },
  { path: 'generate', component: CicdGeneratorComponent },
  // optionally add a wildcard route
  { path: '**', redirectTo: 'generate' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
