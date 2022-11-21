import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

import { map } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class JobsService {  

  constructor(private http: HttpClient) { }

  private languageApiUrl = environment.apiUrl + 'Jobs/GetJobsStatistics2';

  GetJobsStatistics(_startDate:string, _endDate:string) {
    const startDate = new Date(_startDate);//"2022-11-15");
    const endDate = new Date(_endDate);//("2022-11-30");
    var sdString = startDate.getFullYear() + "-" + (startDate.getMonth()+1) + "-" + startDate.getDate();
    var edString = endDate.getFullYear() + "-" + (endDate.getMonth()+1) + "-" + endDate.getDate();

    return this.http.get<any>(this.languageApiUrl+"/"+ sdString + "/" + edString).pipe(
      map((result) => {
        console.log('result:' + result);
        return result;
      })
    );
  }
}
