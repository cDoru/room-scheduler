import { Component, ViewChild, AfterViewInit } from '@angular/core';
import {jqxSchedulerComponent} from '../../../../node_modules/jqwidgets-framework/jqwidgets-ts/angular_jqxscheduler';
import { RoomSelector } from './../../rooms/roomSelector.component';

import {EventService} from '../shared/event.service'
@Component({
  selector: 'rs-calendar-component',
  templateUrl: './rs-calendar.component.html',
  providers: [EventService, RoomSelector]
})

export class RSCalendarComponent {
    @ViewChild('schedulerReference') scheduler: jqxSchedulerComponent;
    private events: any;
    public startDate;

    source: any =
    {
        dataType: "array",
        dataFields: [
            { name: 'id', type: 'string' },
            { name: 'description', type: 'string' },
            { name: 'location', type: 'string' },
            { name: 'subject', type: 'string' },
            { name: 'calendar', type: 'string' },
            { name: 'start', type: 'date' },
            { name: 'end', type: 'date' }
        ],
        id: 'id',
        localData: []
    };

    dataAdapter: any = new jqx.dataAdapter(this.source);
    date: any = new jqx.date(2017, 11, 1);

    appointmentDataFields: any =
    {
        from: "start",
        to: "end",
        id: "id",
        description: "description",
        location: "location",
        subject: "subject",
        resourceId: "calendar"
    };

    resources: any =
    {
        colorScheme: "scheme05",
        dataField: "calendar",
        source: new jqx.dataAdapter(this.source)
    };

    views: any[] =
    [
        { type: 'dayView', showWeekends: false, timeRuler: { scaleStartHour: 9, scaleEndHour: 18 } },
        { type: 'weekView', showWeekends: false, timeRuler: { scaleStartHour: 9, scaleEndHour: 18 } },
      //   { type: 'monthView', showWeekends: false }
    ];  

    constructor(private _eventService: EventService) {
        console.log(this.events);
    }

    ngAfterViewInit(): void {
        this.scheduler.ensureAppointmentVisible('id1');

        this.events = [];
        const events = this._eventService.listEvents(null, null , null).subscribe((events: Event[]) => {
            for (let event of events) {
                this.events.push({
                    id: event['id'],
                    // description: "Some descript",
                    location: "",
                    subject: "Masaj",
                    calendar: "Room " + event['id'],
                   start: new Date(event['startDate']),
                   end: new Date(event['endDate']),
                });
            };

        
            this.source.localData = this.events;
            this.dataAdapter = new jqx.dataAdapter(this.source);
        });
    }

    

}

