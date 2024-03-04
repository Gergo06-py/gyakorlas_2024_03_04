import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-tippek',
  templateUrl: './tippek.component.html',
  styleUrl: './tippek.component.css',
})
export class TippekComponent {
  @Input() tips: any;
  oszlopok = ['Sz1', 'Sz2', 'Sz3', 'Sz4', 'Sz5'];
}
