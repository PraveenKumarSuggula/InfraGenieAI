import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { cicdGenerationRequest } from 'src/models/cicd-generator';

@Injectable({
  providedIn: 'root'
})
export class CicdGeneratorService {

  constructor(private http: HttpClient) { }

  baseURL: string = "https://localhost:44300/api/cicd/"
  onGenerate(cicdRequest: cicdGenerationRequest): Observable<string> {
    console.log("cicdRequest: --", cicdRequest);
    return this.http.post<{yaml: string}>(this.baseURL + 'generate', cicdRequest).pipe(
        map(res => res.yaml)
      );
  }
}
