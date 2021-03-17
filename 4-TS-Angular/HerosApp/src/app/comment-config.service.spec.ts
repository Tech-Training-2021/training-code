import { TestBed } from '@angular/core/testing';

import { CommentConfigService } from './comment-config.service';

describe('CommentConfigService', () => {
  let service: CommentConfigService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CommentConfigService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
