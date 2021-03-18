import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appInputFormat]'
})
export class InputFormatDirective {
  @Input('appInputFormat') format;
  constructor(private er:ElementRef) { }
  // @HostListener('focus') onFocus(){
  //   console.log('On focus completed');
  // }
  @HostListener('blur') onBlur(){
    let value:string=this.er.nativeElement.value;
    if(this.format=='lowercase')
      this.er.nativeElement.value=value.toLowerCase();
    else
    this.er.nativeElement.value=value.toUpperCase();
    console.log('On blur completed');
  }
}
