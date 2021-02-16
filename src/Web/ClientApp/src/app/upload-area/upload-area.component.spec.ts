import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UploadAreaComponent } from './upload-area.component';

describe('UploadAreaComponent', () => {
  let component: UploadAreaComponent;
  let fixture: ComponentFixture<UploadAreaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UploadAreaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UploadAreaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
