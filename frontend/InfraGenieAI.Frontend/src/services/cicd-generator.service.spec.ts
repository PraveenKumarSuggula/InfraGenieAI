import { TestBed } from '@angular/core/testing';

import { CicdGeneratorService } from './cicd-generator.service';

describe('CicdGeneratorService', () => {
  let service: CicdGeneratorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CicdGeneratorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
