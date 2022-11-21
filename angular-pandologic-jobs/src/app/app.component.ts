import { Component, OnInit, AfterViewInit } from '@angular/core';
import { RouterLinkWithHref } from '@angular/router';
import { ChartType } from 'angular-google-charts';
import { JobsService } from './services/jobs.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, AfterViewInit {
  constructor(private jobsService: JobsService) {}
  startDate: any;
  endDate: any;
  title = 'Cumulative job views vs. prediction';
  type = ChartType.LineChart;
  data:any = [];

   columnNames = ["Date", "Active Jobs", "Jobs Views","Predicted Jobs"];
  options = {
     hAxis: {
        title: 'Jobs'
     },
     vAxis:{
        title: 'Jobs Views'
     },
   pointSize:5
  };
  width = 800;
  height = 400;

async ngAfterViewInit() {
  // this.jobsService.GetJobsStatistics().subscribe((result) => {
  //   // this.data = result;
  //    // this.data1 = [];
  //    var d1:any = [];
  //    console.log('Data: ' + result);
  //    for (let i = 0; i < result.data.length; i++) {
  //     d1.push(result.selectedDays[i]);
  //     d1.push(result.data[i][0]);
  //     d1.push(result.data[i][1]);
  //     d1.push(result.data[i][2]);
  //     this.data.push(d1);
  //     d1 = [];
  //    }

  //  });
}

onSubmit(){
  //console.log(event);
}

onClick(){
  console.log(this.startDate);
  console.log(this.endDate);
  this.jobsService.GetJobsStatistics(this.startDate , this.endDate).subscribe((result) => {
     var d1:any = [];
     this.data = [];
     console.log('Data: ' + result);
     for (let i = 0; i < result.data.length; i++) {
      d1.push(result.selectedDays[i]);
      d1.push(result.data[i][0]);
      d1.push(result.data[i][1]);
      d1.push(result.data[i][2]);
      this.data.push(d1);
      d1 = [];
     }

   });
}

  async ngOnInit() {
    let date = new Date();
    this.startDate = new Date(date.getFullYear(), date.getMonth(), date.getDate());
    this.endDate = new Date(date.getFullYear(), date.getMonth(), date.getDate()+9);
    this.jobsService.GetJobsStatistics(this.startDate , this.endDate).subscribe((result) => {
      var d1:any = [];
      console.log('Data: ' + result);
      for (let i = 0; i < result.data.length; i++) {
       d1.push(result.selectedDays[i]);
       d1.push(result.data[i][0]);
       d1.push(result.data[i][1]);
       d1.push(result.data[i][2]);
       this.data.push(d1);
       d1 = [];
      }

    });
  }
}
