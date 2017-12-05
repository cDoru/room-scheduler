import {Component,Output, ElementRef, AfterViewInit} from '@angular/core';
import {NgbModal, NgbModalRef} from '@ng-bootstrap/ng-bootstrap';
import {Router} from '@angular/router';

import {RoomService}  from './../../rooms/shared/room.service';
import {Room} from './../../shared/models/room.model';
import {UserService} from '../../users/shared/users.service';
import {User} from '../../shared/models/user.model';
import {RegisterFormComponent} from '../user-register/register-form.component';
import {RoomEditorComponent} from './../../rooms/room-editor/room-editor.component';

@Component({
    selector: 'admin-component',
    templateUrl: './admin.component.html',
    styleUrls: [],
    providers: [UserService, RoomService],
})

export class AdminComponent implements AfterViewInit{

    public users:User[];
    public selectedUser: User;
    public rooms: Room[];
    public selectRoom: Room;
      

    constructor(private userService:UserService, private roomService: RoomService, private modalService: NgbModal) {}

    ngAfterViewInit(): void {
        
        this.users= [];
        this.rooms= [];
        
        this.userService.listUsers().subscribe((users: any) => {
            for (let user of users) {
                this.users.push(<User>user);
            }
        });

        this.roomService.roomList().subscribe((rooms: any) => {
            for (let room of rooms) {
                this.rooms.push(<Room>room);
            }
        });


    }

    onSelectUser(user: User) {
        this.selectedUser = user;
        const modalRef:NgbModalRef = this.modalService.open(RegisterFormComponent);
        
    }

    // onSelectRoom(room :Room) {
    //     this.selectRoom = room;
        
    // }

    onAddRoom() {
        const modalRef:NgbModalRef = this.modalService.open(RoomEditorComponent);
    }
}