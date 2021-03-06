import {Register} from 'ts-node/dist';
import {AdminComponent} from './admin/admin.component';
import {NgxPaginationModule} from 'ngx-pagination';

import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {CoreModule} from '../core/core.module';
import {SharedModule} from '../shared/shared.module';
import {UserService} from './shared/users.service';
import {LoginPageComponent} from './login-form/login-page.component';
import {LoginFormComponent} from './login-form/login-form.component';
import {RegisterFormComponent} from './register-form/register-form.component';
import {RegisterPageComponent} from './register-form/register-page.component';


const routes: Routes = [
    {path: 'login', component: LoginPageComponent},
    {path: 'register', component: RegisterPageComponent},
    {path: 'admin', component: AdminComponent}
];

@NgModule({
    imports: [
        RouterModule.forRoot(routes),
        CoreModule,
        SharedModule,
        NgxPaginationModule
    ],
    providers: [UserService],
    declarations: [LoginFormComponent, LoginPageComponent, RegisterPageComponent, RegisterFormComponent, AdminComponent],
    exports: [LoginFormComponent, LoginPageComponent, RegisterPageComponent, RegisterFormComponent, AdminComponent],
    entryComponents: [LoginFormComponent, RegisterFormComponent]
})

export class UsersModule {

}