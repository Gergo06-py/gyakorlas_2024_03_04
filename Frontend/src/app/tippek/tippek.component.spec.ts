import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TippekComponent } from './tippek.component';

describe('TippekComponent', () => {
  let component: TippekComponent;
  let fixture: ComponentFixture<TippekComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TippekComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TippekComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
