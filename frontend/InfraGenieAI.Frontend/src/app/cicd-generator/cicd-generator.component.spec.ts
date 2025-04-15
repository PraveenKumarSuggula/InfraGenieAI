import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CicdGeneratorComponent } from './cicd-generator.component';

describe('CicdGeneratorComponent', () => {
  let component: CicdGeneratorComponent;
  let fixture: ComponentFixture<CicdGeneratorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CicdGeneratorComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CicdGeneratorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
