import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CanBanBoardComponent } from './can-ban-board.component';

describe('CanBanBoardComponent', () => {
  let component: CanBanBoardComponent;
  let fixture: ComponentFixture<CanBanBoardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CanBanBoardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CanBanBoardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
