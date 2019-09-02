import { InsideModule } from './inside.module';

describe('InsideModule', () => {
  let insideModule: InsideModule;

  beforeEach(() => {
    insideModule = new InsideModule();
  });

  it('should create an instance', () => {
    expect(insideModule).toBeTruthy();
  });
});
